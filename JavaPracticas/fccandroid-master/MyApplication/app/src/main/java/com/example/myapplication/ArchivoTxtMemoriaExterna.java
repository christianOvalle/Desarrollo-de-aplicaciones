package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class ArchivoTxtMemoriaExterna extends AppCompatActivity implements View.OnClickListener {

    //<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />

    EditText editTextNombreArchivo,editTextCuerpoArchivo;
    Button btnGrabar,btnRecuperar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_archivo_txt_memoria_externa);

        this.editTextNombreArchivo = (EditText) this.findViewById(R.id.editTextArchivoTxtMemoriaExternaNombreArchivo);
        this.editTextCuerpoArchivo = (EditText) this.findViewById(R.id.editTextArchivoTxtMemoriaExternaCuerpoArchivo);

        this.btnGrabar = (Button) this.findViewById(R.id.btnArchivoTxtMemoriaExternaGrabar);
        this.btnRecuperar = (Button) this.findViewById(R.id.btnArchivoTxtMemoriaExternaRecuperar);

        this.btnGrabar.setOnClickListener(this);
        this.btnRecuperar.setOnClickListener(this);

    }

    public void Limpiar(){
        this.editTextNombreArchivo.setText("");
        this.editTextCuerpoArchivo.setText("");
    }

    public void grabar() {
        Log.d("ArchivosAndroid","Directorio actual path memoria externa "+ getExternalFilesDir(null));

        String nomarchivo = this.editTextNombreArchivo.getText().toString();
        String contenido = this.editTextCuerpoArchivo.getText().toString();
        try {
            //https://developer.android.com/reference/java/io/File
            /*
            *getExternalFilesDir(null)
            * Devuelve la ruta absoluta al directorio en el dispositivo de almacenamiento externo / compartido principal donde la aplicación puede colocar los archivos persistentes que posee.
            * Estos archivos son internos de las aplicaciones y, por lo general, el usuario no puede verlos como medios.
            * Es como getFilesDir()que estos archivos se eliminarán cuando se desinstale la aplicación
            * */
            //Devuelve la ruta absoluta al directorio en el dispositivo de almacenamiento externo
            File file =new  File(getExternalFilesDir(null), nomarchivo);

            // convertir datos en forma de caracteres en datos en forma de byte
            OutputStreamWriter osw = new OutputStreamWriter(
                    new FileOutputStream(file));
            osw.write(contenido);
            osw.flush();//obliga a escribir todos los datos presentes en el escritor en el destino correspondiente
            osw.close();
            Toast.makeText(this, "Los datos fueron grabados correctamente",
                    Toast.LENGTH_SHORT).show();

            this.Limpiar();
        } catch (IOException ioe) {
            Toast.makeText(this, "No se pudo grabar",
                    Toast.LENGTH_SHORT).show();
        }
    }

    public void recuperar() {
        Log.d("ArchivosAndroid","Directorio actual path memoria externa "+ getExternalFilesDir(null));
        File file =new File(getExternalFilesDir(null), this.editTextNombreArchivo.getText().toString());
        try {
            FileInputStream fIn = new FileInputStream(file);
            InputStreamReader archivo = new InputStreamReader(fIn);
            BufferedReader br = new BufferedReader(archivo);
            String linea = br.readLine();
            String todo = "";
            while (linea != null) {
                todo = todo + linea + " ";
                linea = br.readLine();
            }
            br.close();
            archivo.close();
            this.editTextCuerpoArchivo.setText(todo);

        } catch (IOException e) {
            Toast.makeText(this, "No se pudo leer",
                    Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    public void onClick(View v) {
        if (v == this.btnGrabar)
            this.grabar();
        else if (v == this.btnRecuperar)
            this.recuperar();
    }
}