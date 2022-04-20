package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;

public class List_p2 extends AppCompatActivity implements AdapterView.OnItemClickListener {


    private ListView Pais;
    String[] Habitantes={"5,000,000","1,250,00","800,000","700,00","900,000"};
    String[] Paises ={"China","USA","Colombia","Mexico","Cuba"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_list_p2);
        this.Pais = findViewById(R.id.Paises);
        this.Pais.setOnClickListener((AdapterView.OnClickListener) this);

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1,Paises);
        Pais.setAdapter(adapter);



    }



    @Override
    public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {

        int PosicionPais= i;
        String PaisListView = this.Pais.getItemAtPosition(i).toString();
        String NumeroHabitantes = this.Habitantes[PosicionPais];

        Toast.makeText(this, PaisListView +" Tiene un cantidad de "+ NumeroHabitantes + " Habitantes", Toast.LENGTH_SHORT).show();
    }
}