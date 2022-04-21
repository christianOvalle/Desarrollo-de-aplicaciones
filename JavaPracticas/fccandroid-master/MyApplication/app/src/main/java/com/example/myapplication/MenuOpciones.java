package com.example.myapplication;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;

public class MenuOpciones extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_opciones);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        /*
        * En el método onCreateOptionsMenu creamos un objeto de la clase MenuInflater y mediante el método inflate vinculamos el identificador del archivo de recursos: R.menu.activity_main y el objeto de la clase menu que llega como parámetro. Debemos retornar true
        * */
        //https://developer.android.com/reference/android/view/MenuInflater
        //Para poder mostrar un menu debemos usar un objeto menuInflater
        //El menu se crea en tiempo de ejecucion partiendo de un xml que definamos
        this.getMenuInflater().inflate(R.menu.menu_opciones1,menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()){
            case R.id.menuItemMenuOpcionesSobreNosotros:
                Toast.makeText(this, "Creado por Eudy Arias", Toast.LENGTH_LONG).show();
                break;
            case R.id.menuItemMenuOpcionesConfiguraciones:
                Toast.makeText(this, "Configuracion pendiente", Toast.LENGTH_LONG).show();
                break;
        }
        return true;
    }
}