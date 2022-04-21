package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

public class CalculadoraRadioButon extends AppCompatActivity implements View.OnClickListener {

    Button btnResultado;
    EditText txtValor1,txtValor2;
    RadioButton radioSuma,radioResta;
    TextView txtVResultado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calculadora_radio_buton);

        this.btnResultado = this.findViewById(R.id.btnResultadoID);
        this.btnResultado.setOnClickListener(this);

        this.txtValor1 = this.findViewById(R.id.editTextNumberValor1ID);
        this.txtValor2 = this.findViewById(R.id.editTextNumberValor2ID);

        this.radioSuma = this.findViewById(R.id.radioButonSumar);
        this.radioResta = this.findViewById(R.id.radioButtonRestar);

        this.txtVResultado = this.findViewById(R.id.resultadoRadioButon);
    }

    @Override
    public void onClick(View v) {


        Toast.makeText(this, "Le has dado clic al boton", Toast.LENGTH_SHORT).show();

        int v1 = Integer.parseInt(this.txtValor1.getText().toString());
        int v2 = Integer.parseInt(this.txtValor2.getText().toString());
        int resultado = 0;
        String operacion = "";
        if (this.radioSuma.isChecked()){
            resultado = v1+v2;
            operacion = "Suma ";
        }else if (this.radioResta.isChecked() == true){
            resultado = v1-v2;
            operacion = "Resta ";
        }
        Toast.makeText(this, "El resultado de la "+operacion+" es "+String.valueOf(resultado), Toast.LENGTH_SHORT).show();
        this.txtVResultado.setText("El resultado de la "+operacion+" es "+String.valueOf(resultado));
    }
}