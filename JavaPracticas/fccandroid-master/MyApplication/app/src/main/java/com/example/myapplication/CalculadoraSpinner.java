package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.Toast;

public class CalculadoraSpinner extends AppCompatActivity implements View.OnClickListener {

    Spinner spinnerOperacion;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calculadora_spinner);

        spinnerOperacion =findViewById(R.id.spinnerOperacion);

        String[] opciones={"sumar","restar","multiplicar","dividir"};
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item, opciones);
        spinnerOperacion.setAdapter(adapter);


    }

    public void sumarDedeSpinner(View v){
        String valor = this.spinnerOperacion.getSelectedItem().toString();
        Toast.makeText(this, ""+valor, Toast.LENGTH_SHORT).show();

    }

    @Override
    public void onClick(View v) {

    }
}