package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class Ejercicio2_P4 extends AppCompatActivity {

    EditText Email,nombre,apellido,whastapp,direccion;

    Button Ejecutar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ejercicio2_p4);

        this.Email = this.findViewById(R.id.editTextTextEmailAddress9);
        this.apellido =this.findViewById(R.id.editTextTextEmailAddress8);
        this.nombre =this.findViewById(R.id.editTextTextEmailAddress3);
        this.whastapp =this.findViewById(R.id.editTextTextEmailAddress7);
        this.direccion=this.findViewById(R.id.editTextTextEmailAddress6);
        this.Ejecutar = this.findViewById(R.id.button13);


        SharedPreferences prefe =getSharedPreferences("datos", Context.MODE_PRIVATE);

        Email.setText(prefe.getString("email",""));
        apellido.setText(prefe.getString("apellido",""));
        nombre.setText(prefe.getString("nombre",""));
        whastapp.setText(prefe.getString("wsp",""));
        direccion.setText(prefe.getString("direccion",""));

        this.Ejecutar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                SharedPreferences preferences = getSharedPreferences("datos",Context.MODE_PRIVATE);

                SharedPreferences.Editor editor = preferences.edit();
                editor.putString("email",Email.getText().toString());
                editor.putString("Edad",apellido.getText().toString());
                editor.putString("Edad",nombre.getText().toString());
                editor.putString("Edad",whastapp.getText().toString());
                editor.putString("Edad",direccion.getText().toString());
                editor.commit();
                finish();


            }
        });


    }
}