package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class Conversion extends AppCompatActivity {

    private EditText Valor1;
    private EditText Valor2;
    private Button ejecutar;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_conversion);

         this.Valor1 = this.findViewById(R.id.editTextNumber);
         this.Valor2 = this.findViewById(R.id.editTextNumber2);
         this.ejecutar = this.findViewById(R.id.button5);

         this.ejecutar.setOnClickListener(new View.OnClickListener() {
             @Override
             public void onClick(View view) {

                 Integer num1 = Integer.parseInt(Valor1.getText().toString());
                 Integer  euro = num1 * 64;
                 Valor2.setText(euro.toString());


             }
         });




    }
}