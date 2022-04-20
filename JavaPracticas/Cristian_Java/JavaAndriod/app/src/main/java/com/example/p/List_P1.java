package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.List;

public class List_P1 extends AppCompatActivity {

    ListView Lista;
    ArrayList<String> Frutas;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_list_p1);

        this.Lista = findViewById(R.id.lista);

       Frutas = new ArrayList<String>();

        Frutas.add("Mango");
        Frutas.add("Cereza");
        Frutas.add("Pera");
        Frutas.add("Aguacate");
        Frutas.add("Piña");
        Frutas.add("Coco");
        Frutas.add("Zapote");

        ArrayAdapter<String> frutas = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1,Frutas);
        Lista.setAdapter(frutas);

    }
}