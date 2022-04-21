package com.example.myapplication;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;

public class MenuOpcionesIcono extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_opciones_icono);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        this.getMenuInflater().inflate(R.menu.menu_opciones_icono1,menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if (item.getItemId() == R.id.MenuItemMenuOpcionesIconoCompartir){
            Toast.makeText(this, "Opcion compartir", Toast.LENGTH_SHORT).show();
        }else if(item.getItemId() == R.id.idOpcion1MenuOpciones){
            Toast.makeText(this, "onOptionsItemSelected opcion 1", Toast.LENGTH_SHORT).show();

        }
        return true;
    }

    /*
    * siempre: siempre se mostrará en la barra de acciones.
nunca: nunca se mostrará y, por lo tanto, estará disponible a través del menú adicional
ifRoom: solo si hay suficiente espacio en la barra de acciones, se mostrará. Tenga en cuenta que, según la documentación, hay un límite en la cantidad de iconos que puede tener en la barra de acciones.
withText: incluirá el título del elemento en la barra de acción
collapseActionView: si este elemento tiene una vista de acción asociada, se volverá plegable (desde API 14 y superior)
    * */
}