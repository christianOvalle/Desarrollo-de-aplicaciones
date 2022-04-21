 package com.example.myapplication;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.LinearLayout;
import android.widget.Switch;
import android.widget.Toast;

import org.w3c.dom.Text;

 public class MenuOpcionesSubMenu extends AppCompatActivity {

     LinearLayout l;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_opciones_sub_menu);

        l = (LinearLayout) this.findViewById(R.id.linearLayoutMenuOpcionesSubMenuContenedor);
    }

     @Override
     public boolean onCreateOptionsMenu(Menu menu) {
        this.getMenuInflater().inflate(R.menu.menu_opciones_sub_menu1,menu);
         return true;
     }

     @Override
     public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        boolean estado = true;
         switch (item.getItemId()){
             case R.id.menuItemMenuOpcionesSubMenuBlanco:
                 this.setTitle("Blanco");
                 this.l.setBackgroundColor(Color.WHITE);
                 break;
             case R.id.menuItemMenuOpcionesSubMenuNegro:
                 this.setTitle("Negro");
                 this.l.setBackgroundColor(Color.BLACK);
                 break;
             case R.id.menuItemMenuOpcionesSubMenuAzul:
                 this.setTitle("Azul");
                 this.l.setBackgroundColor(Color.BLUE);

                 break;
             default:
                 estado= super.onOptionsItemSelected(item);
                 break;
         }
         //Toast.makeText(this, "Estado "+estado, Toast.LENGTH_SHORT).show();
        return estado;
     }
 }