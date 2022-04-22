package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;

public class CambiarOrientacion extends AppCompatActivity implements View.OnClickListener {

    Button Cambiar;
    LinearLayout horiverti;
    boolean CambiarOrientacion = true;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cambiar_orientacion);

        this.horiverti = findViewById(R.id.Liner1);
        this.Cambiar = findViewById(R.id.button51);
        this.Cambiar.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
     this.CambiarOrientacion = !this.CambiarOrientacion;
     if(CambiarOrientacion){
         this.horiverti.setOrientation(horiverti.HORIZONTAL);
     }
     else{
         this.horiverti.setOrientation(horiverti.VERTICAL);

     }


    }
}