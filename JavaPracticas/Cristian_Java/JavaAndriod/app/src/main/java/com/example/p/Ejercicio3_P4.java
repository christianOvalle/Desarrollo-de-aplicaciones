package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class Ejercicio3_P4 extends AppCompatActivity implements View.OnClickListener {

    EditText texto;
    Button Guardar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ejercicio3_p4);

        this.texto = this.findViewById(R.id.editTextTextMultiLine3);
        this.Guardar= this.findViewById(R.id.button16);
        this.Guardar.setOnClickListener(this);

        SharedPreferences prefe = getSharedPreferences("Primer_archivo_Cristian", Context.MODE_PRIVATE);

        texto.setText(prefe.getString("Nombre",""));


    }

    @Override
    public void onClick(View view) {

        SharedPreferences preferences = getSharedPreferences("Primer_archivo_Cristian",Context.MODE_PRIVATE);

        SharedPreferences.Editor edit = preferences.edit();
        edit.putString("Nombre",texto.getText().toString());
        edit.commit();
        this.finish();

    }
}