package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class Ejercicio1_P4 extends AppCompatActivity {

    EditText Email;
    Button Ejecutar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ejercicio1_p4);

            this.Email = this.findViewById(R.id.editTextTextEmailAddress2);
            this.Ejecutar = this.findViewById(R.id.button14);


        SharedPreferences prefe =getSharedPreferences("datos",Context.MODE_PRIVATE);
        Email.setText(prefe.getString("email",""));

        this.Ejecutar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                SharedPreferences preferences = getSharedPreferences("datos",Context.MODE_PRIVATE);

                SharedPreferences.Editor editor = preferences.edit();
                editor.putString("email",Email.getText().toString());
                editor.commit();
                finish();


            }
        });


    }
}