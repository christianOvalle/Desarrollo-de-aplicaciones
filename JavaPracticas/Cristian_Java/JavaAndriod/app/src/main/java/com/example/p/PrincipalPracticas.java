package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.time.Year;

public class PrincipalPracticas extends AppCompatActivity implements AdapterView.OnItemClickListener {

    String[] Menu=
            {"Calculadora",
            "Coversion",
            "Guardar Dato",
            "Pulsar ImageButton y mostrar mensaje",
            "Presentar 7 Frutas",
            "Mostra paises y su cantidad de habitantes",
            "Mostra saludo y mas",
            "Mostrar lenguajes",
            "Mostrar un web view",
            "Numero Mayor",
            "Taza de cambio",
            "Mostrar años elegido"};

    ListView Practicas;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_principal_practicas);

        this.Practicas = this.findViewById(R.id.PrincipalList);
        this.Practicas.setOnItemClickListener(this);

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1,Menu);
        Practicas.setAdapter(adapter);
    }

    @Override
    public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
        int IdPractica = i;
        String Practica = this.Practicas.getItemAtPosition(IdPractica).toString();

        switch (IdPractica){

            case 0:
                Intent intent = new Intent(this,Calculadora.class);
                startActivity(intent);
                break;
            case 1:
                Intent intent1 = new Intent(this,Conversion.class);
                startActivity(intent1);
                break;
            case 2:
                Intent intent2 = new Intent(this,Ejercicio1_P4.class);
                startActivity(intent2);
                break;
            case 3:
                Intent intent3 = new Intent(this,ImageButon.class);
                startActivity(intent3);
                break;
            case 4:
                Intent intent4 = new Intent(this,List_P1.class);
                startActivity(intent4);
                break;
            case 5:
                Intent intent5 = new Intent(this,List_p2.class);
                startActivity(intent5);
                break;
            case 6:
                Intent intent6 = new Intent(this,Mensaje.class);
                startActivity(intent6);
                break;
            case 7:
                Intent intent7 = new Intent(this,MostrarLenguajes.class);
                startActivity(intent7);
                break;
            case 8:
                Intent intent8 = new Intent(this,MostrarOtraVista.class);
                startActivity(intent8);
                break;
            case 9:
                Intent intent9 = new Intent(this,NumeroMayor.class);
                startActivity(intent9);
                break;
            case 10:
                Intent intent10 = new Intent(this,TazaDeCambio.class);
                startActivity(intent10);
                break;
            case 11:
                Intent intent11 = new Intent(this, Years.class);
                startActivity(intent11);
                break;
        }

    }
}