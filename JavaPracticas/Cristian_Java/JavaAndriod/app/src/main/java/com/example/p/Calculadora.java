package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.media.audiofx.AudioEffect;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

public class Calculadora extends AppCompatActivity implements View.OnClickListener {

    private EditText V1;
    private EditText V2;
    private Button Ejecutar;
    private RadioButton RadioSuma,RadioResta,RadioDividir,RadioMulti,RadioPow,RadioModulo;
    private TextView Resultado;




    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calculadora);


        this.V1 = this.findViewById(R.id.editTextNumber5);
        this.V2 = this.findViewById(R.id.editTextNumber6);
        this.Ejecutar = findViewById(R.id.button6);
        this.Ejecutar.setOnClickListener(this);

        this.RadioSuma = this.findViewById(R.id.radioButton);
        this.RadioResta = this.findViewById(R.id.radioButton2);
        this.RadioMulti = this.findViewById(R.id.radioButton3);
        this.RadioDividir = this.findViewById(R.id.radioButton4);
        this.RadioPow = this.findViewById(R.id.radioButton5);
        this.RadioModulo = this.findViewById(R.id.radioButton6);

        this.Resultado = this.findViewById(R.id.textView4);

    }


    @Override
    public void onClick(View view) {

        Double num1 = Double.parseDouble(V1.getText().toString());
        Double num2 = Double.parseDouble(V2.getText().toString());


        Double Valor;
        String Mensaje = "";
        if (this.RadioSuma.isChecked()) {
            Valor = num1 + num2;
            Resultado.setText((Valor.toString()));
        } else if (this.RadioResta.isChecked()) {
            Valor = num1 - num2;
            Resultado.setText((Valor.toString() + ","));
        } else if (this.RadioMulti.isChecked()) {
            Valor = num1 * num2;
            Resultado.setText((Valor.toString() + ","));
        } else if (this.RadioModulo.isChecked()) {
            Valor = num1 % num2;
            Resultado.setText((Valor.toString() + ","));
        } else if (this.RadioDividir.isChecked()) {
            if (num2 == 0 || num1 == 0) {

                Toast.makeText(this, "No se puede dividir entre cero", Toast.LENGTH_SHORT).show();

            } else {

                Valor = num1 / num2;
                Resultado.setText((Valor.toString() + ","));
            }


        } else if (this.RadioPow.isChecked()) {
             Valor =  Math.pow(num1, num2);
            Resultado.setText((Valor.toString() + ","));


        }
    }
    }
