package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;

public class TazaDeCambio extends AppCompatActivity {


    private Button Convertir;
    private TextView Resultado;
    private EditText Monto;
    private RadioButton USDaDOP;
    private RadioButton EURAaDOP;
    private RadioButton GBPaDOP;
    private RadioButton CHFaDOP;
    private RadioButton JPYaDOP;
    private RadioButton HKDaDop;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_taza_de_cambio);

        this.Convertir = this.findViewById(R.id.button7);
        this.Resultado = this.findViewById(R.id.textView7);
        this.Monto = this.findViewById(R.id.editTextNumber7);
        this.USDaDOP = this.findViewById(R.id.radioButton16);
        this.EURAaDOP = this.findViewById(R.id.radioButton15);
        this.GBPaDOP = this.findViewById(R.id.radioButton14);
        this.CHFaDOP = this.findViewById(R.id.radioButton13);
        this.JPYaDOP = this.findViewById(R.id.radioButton12);
        this.HKDaDop = this.findViewById(R.id.radioButton11);


        this.Convertir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Double Usuario = Double.parseDouble(Monto.getText().toString());

                Double dinero;
                if(USDaDOP.isChecked()){
                 dinero = Usuario * 55.67;
                 Resultado.setText(dinero.toString());

                }
                else if(EURAaDOP.isChecked()){
                    dinero = Usuario * 63.12;
                    Resultado.setText(dinero.toString());

                }
                else if(GBPaDOP.isChecked()){
                    dinero = Usuario * 72.09;
                    Resultado.setText(dinero.toString());

                }
                else if(CHFaDOP.isChecked()){
                    dinero = Usuario * 58.99;
                    Resultado.setText(dinero.toString());

                }
                else if(JPYaDOP.isChecked()){
                    dinero = Usuario * 0.44;
                    Resultado.setText(dinero.toString());

                }
                else if(HKDaDop.isChecked()){
                    dinero = Usuario * 7.02;
                    Resultado.setText(dinero.toString());

                }



            }
        });


    }
}