package com.example.myapplication;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    TextView resultado;
    EditText valor1,valor2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);





        this.valor1 = (EditText) this.findViewById(R.id.editTextTextPersonName);
        this.valor2= (EditText) this.findViewById(R.id.editTextTextPersonName2);
        this.resultado = (TextView) this.findViewById(R.id.textView);

        //Registramos el context menu para el view
        registerForContextMenu(this.valor1);

    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        menu.setHeaderTitle("Elija el color de fondo:");
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu1, menu);
    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
        String viewIDString = String.valueOf(item.getItemId());
        Toast.makeText(this, "ejemplo text toast "+viewIDString, Toast.LENGTH_SHORT).show();


        int color = android.graphics.Color.rgb(255,255,255);
        switch (item.getItemId()){
            case R.id.item1:
                    color = android.graphics.Color.rgb(255,0,0);
                break;
            case R.id.item2:
                color = android.graphics.Color.rgb(0   ,255,0);
                break;
            case R.id.item3:
                color = android.graphics.Color.rgb(0,0,255);
                break;
        }
        this.valor1.setBackgroundColor(color);
        this.valor2.setBackgroundColor(color);
        return true;
    }

    public void Sumar(View v){
        int v1=0,v2=0,r=0;
        v1 = Integer.parseInt( this.valor1.getText().toString());

        v2 = Integer.parseInt( this.valor2.getText().toString());
        r = v1+v2;

        this.resultado.setText(String.valueOf(r));
    }
    public void LlamarOtraVentana(View v){
        Intent i = new Intent(this, CalculadoraRadioButon.class );
        startActivity(i);
    }
    public void LlamarCalculadoraSpinner(View v){
        Intent i = new Intent(this, CalculadoraSpinner.class );
        startActivity(i);
    }
    public void LlamarBuscadorWeb(View v){
        Intent i = new Intent(this, BuscadorWeb.class );
        startActivity(i);
    }
    public void LlamarListView(View v){
        Intent i = new Intent(this, ListViewExample.class );
        startActivity(i);
    }
    public void LlamarListaLenguajesProgramacion(View v){
        Intent i = new Intent(this, CheckBoxExample.class );
        startActivity(i);
    }
    public void LlamarImageButton(View v){
        Intent i = new Intent(this, ImageButtonExample.class );
        startActivity(i);
    }
}