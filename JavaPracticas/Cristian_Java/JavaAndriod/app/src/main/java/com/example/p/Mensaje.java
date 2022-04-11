package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class Mensaje extends AppCompatActivity {


    private Button bt1;
    private Button bt2;
    int m = 0;
    private Button Multi;
    int Resul = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mensaje);

        this.bt1 = this.findViewById(R.id.button2);
        this.bt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Toast.makeText(Mensaje.this, "Hola Cristian", Toast.LENGTH_SHORT).show();


            }
        });

        this.bt2 = this.findViewById(R.id.button3);
        this.bt2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                m = m + 1;

                Toast.makeText(Mensaje.this, m+"", Toast.LENGTH_SHORT).show();
            }
        });

        this.Multi = this.findViewById(R.id.button4);
        this.Multi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

           Resul = m * 2;

                Toast.makeText(Mensaje.this, " Valor de la multiplicacion: "+Resul, Toast.LENGTH_SHORT).show();


            }
        });



    }
}