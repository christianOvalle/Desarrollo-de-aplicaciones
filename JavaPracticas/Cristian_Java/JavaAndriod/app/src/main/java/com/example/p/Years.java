package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.Toast;

public class Years extends AppCompatActivity implements View.OnClickListener {

     private Spinner Lista;
    private  Button Ver;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_years);


        this.Ver = this.findViewById(R.id.button8);
        this.Ver.setOnClickListener(this);
        this.Lista = this.findViewById(R.id.spinner);

        String[] Numeros = new String[41];
        int M = 0;
        for(Integer i = 1980; i < 2021; i++ ){

            Numeros[M] = i.toString();
            M++;

        }

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_item, Numeros);
        Lista.setAdapter(adapter);


    }


    @Override
    public void onClick(View view) {


        Toast.makeText(this,    Lista.getSelectedItem().toString(), Toast.LENGTH_SHORT).show();
    }
}