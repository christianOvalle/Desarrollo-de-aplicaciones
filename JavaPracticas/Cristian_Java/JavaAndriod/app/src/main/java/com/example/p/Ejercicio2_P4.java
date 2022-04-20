package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class Ejercicio2_P4 extends AppCompatActivity {

    EditText Email,Years;
    Button Ejecutar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ejercicio1_p4);

        this.Email = this.findViewById(R.id.editTextTextEmailAddress3);
        this.Years =this.findViewById(R.id.editTextNumber8);
        this.Ejecutar = this.findViewById(R.id.button13);


        SharedPreferences prefe =getSharedPreferences("datos", Context.MODE_PRIVATE);

        Email.setText(prefe.getString("email",""));
        //Years.setText(prefe.getString("Edad",""));

        this.Ejecutar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                SharedPreferences preferences = getSharedPreferences("datos",Context.MODE_PRIVATE);

                SharedPreferences.Editor editor = preferences.edit();
                editor.putString("email",Email.getText().toString());
                //editor.putString("Edad",Years.getText().toString());
                editor.commit();
                finish();


            }
        });


    }
}