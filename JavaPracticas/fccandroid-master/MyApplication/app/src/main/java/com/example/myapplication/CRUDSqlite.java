package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class CRUDSqlite extends AppCompatActivity implements View.OnClickListener {

    private EditText et1, et2, et3;
    private Button btnInsertar,btnCancelar,btnEditar,btnEliminar,btnBuscar;

    AdministradorBaseDeDatosSqlite admin = new AdministradorBaseDeDatosSqlite(this);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_c_r_u_d_sqlite);

        this.et1 = (EditText) findViewById(R.id.editTextCrudID);
        this.et2 = (EditText) findViewById(R.id.editTextCrudCedula);
        this.et3 = (EditText) findViewById(R.id.editTextCrudNombre);

        this.btnInsertar = (Button) findViewById(R.id.btnCrudInsertar);
        this.btnCancelar = (Button) findViewById(R.id.btnCrudCancelar);
        this.btnEditar = (Button) findViewById(R.id.btnCrudEditar);
        this.btnEliminar = (Button) findViewById(R.id.btnCrudEliminar);
        this.btnBuscar = (Button) findViewById(R.id.btnCrudBuscarID);


        this.btnInsertar.setOnClickListener(this);
        this.btnCancelar.setOnClickListener(this);
        this.btnEditar.setOnClickListener(this);
        this.btnEliminar.setOnClickListener(this);
        this.btnBuscar.setOnClickListener(this);
    }

    public void Cancelar(){
        this.et1.setText("");
        this.et2.setText("");
        this.et3.setText("");
    }

    public void Insertar(){
        //https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper
        //Abrimos la base de datos o creamos para leer o escribir
        SQLiteDatabase bd = admin.getWritableDatabase();

        String cedula = this.et2.getText().toString();
        String nombre = this.et3.getText().toString();

        bd.execSQL("INSERT INTO personas (cedula,nombre) VALUES ('"+cedula+"','"+nombre+"') ");

        /*
         * Alternativa 2
         * //Insertar un registro con execSQL(), utilizando argumentos
         * String[] args = new String[]{"233-44455556-6","usuario1"};
         * db.execSQL("INSERT INTO personas (cedula,nombre) VALUES ('?','?')  ", args);
         * */

        /*
        * //Alternativa 3
        * //Creamos el registro a insertar como objeto ContentValues
        * ContentValues nuevoRegistro = new ContentValues();
        * nuevoRegistro.put("cedula", "200-33344566-4");
        * nuevoRegistro.put("nombre","nombre persona");
        * //Insertamos el registro en la base de datos
        * db.insert("personas", null, nuevoRegistro);
        * */


        bd.close();

        this.Cancelar();
        Toast.makeText(this, "Se cargaron los datos de la persona",
                Toast.LENGTH_SHORT).show();
    }

    public void Editar(){
        //https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper
        //Abrimos la base de datos o creamos para leer o escribir
        SQLiteDatabase bd = admin.getWritableDatabase();

        String id = this.et1.getText().toString();
        String cedula = this.et2.getText().toString();
        String nombre = this.et3.getText().toString();

        bd.execSQL("UPDATE personas SET cedula ='"+cedula+"',nombre='"+nombre+"' WHERE id="+id+"  ");

        /*
         * Alternativa 2
         * //Editar un registro con execSQL(), utilizando argumentos
         * String[] args = new String[]{"233-44455556-6","usuario1"};
         * db.execSQL("UPDATE personas SET cedula ='?',nombre='?' WHERE id=? ", args);
         * */

        /*
        * Alternativa 3
        * //Establecemos los campos-valores a actualizar
        * ContentValues valores = new ContentValues();
        * valores.put("nombre","usunuevo");
        * //Actualizamos el registro en la base de datos
        * db.update("personas", valores, "id=2", null);
        * */

        bd.close();

        this.Cancelar();
        Toast.makeText(this, "Se edito los datos de la persona",
                Toast.LENGTH_SHORT).show();
    }

    public void Eliminar(){
        //https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper
        //Abrimos la base de datos o creamos para leer o escribir
        SQLiteDatabase bd = admin.getWritableDatabase();

        String id = this.et1.getText().toString();

        bd.execSQL("DELETE FROM personas WHERE id="+id+"  ");

        /*
        * Alternativa 2
        * //Eliminar un registro con execSQL(), utilizando argumentos
        * String[] args = new String[]{"usuario1"};
        * db.execSQL("DELETE FROM personas WHERE nombre=?", args);
        * */



        /*
        * Alternativa 3
        * //Eliminamos el registro de la persona '6'
        * db.delete("personas", "id=6", null);
        * */

        bd.close();

        this.Cancelar();
        Toast.makeText(this, "Se elimino los datos de la persona",
                Toast.LENGTH_SHORT).show();
    }
    public void Leer(){
        //https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper
        //Abrimos la base de datos o creamos para leer o escribir
        SQLiteDatabase bd = admin.getWritableDatabase();

        String id = this.et1.getText().toString();


        Cursor fila = bd.rawQuery(
                "select cedula,nombre  from personas where id="+id+"" , null);

        if (fila.moveToFirst()) {
            et2.setText(fila.getString(0));
            et3.setText(fila.getString(1));
        } else
            Toast.makeText(this, "No existe una persona con dicho ID",
                    Toast.LENGTH_SHORT).show();


        bd.close();

    }

    @Override
    public void onClick(View v) {
        if (v == this.btnInsertar)
            this.Insertar();
        else if (v == this.btnEditar)
            this.Editar();
        else if (v == this.btnEliminar)
            this.Eliminar();
        else if (v == this.btnCancelar)
            this.Cancelar();
        else if (v == this.btnBuscar)
            this.Leer();

    }
}