package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class NumeroMayor extends AppCompatActivity implements View.OnClickListener {


    Button mayor;
    EditText Num1;
    EditText Num2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_numero_mayor);


        this.mayor = findViewById(R.id.button10);
        this.mayor.setOnClickListener(this);

        this.Num1 = findViewById(R.id.editTextNumber3);
        this.Num2 = findViewById(R.id.editTextNumber4);


    }

    @Override
    public void onClick(View view) {

        Integer Valor1 = Integer.parseInt(Num1.getText().toString());
        Integer Valor2 = Integer.parseInt(Num2.getText().toString());

        if(Valor1>Valor2){

            Toast.makeText(this, "El mayor es "+Valor1, Toast.LENGTH_SHORT).show();
        }
        else if(Valor2>Valor1){
            Toast.makeText(this, "El mayor es "+Valor2, Toast.LENGTH_SHORT).show();
        }
         else {
            Toast.makeText(this, "Ambos numeros son iguales", Toast.LENGTH_SHORT).show();
        }



    }
}