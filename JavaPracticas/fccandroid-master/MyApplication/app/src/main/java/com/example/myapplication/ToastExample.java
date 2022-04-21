package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class ToastExample extends AppCompatActivity implements View.OnClickListener {

    Button btnCorto, btnLargo,btnGravity,btnPersonalizado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_toast_example);

        this.btnCorto = (Button) this.findViewById(R.id.btnToastExampleCorto) ;
        this.btnLargo = (Button) this.findViewById(R.id.btnToastExampleLargo) ;
        this.btnGravity = (Button) this.findViewById(R.id.btnToastExampleGravity) ;
        this.btnPersonalizado = (Button) this.findViewById(R.id.btnToastExamplePersonalizado) ;

        this.btnCorto.setOnClickListener(this);
        this.btnLargo.setOnClickListener(this);
        this.btnGravity.setOnClickListener(this);
        this.btnPersonalizado.setOnClickListener(this);
    }
    public void crearToastCorto(){
        Toast.makeText(this, " "+this.btnCorto.getText().toString(), Toast.LENGTH_SHORT).show();
    }
    public void crearToastLargo(){
        Toast.makeText(this, " "+this.btnLargo.getText().toString(), Toast.LENGTH_LONG).show();
    }
    public void crearToastGravity(){
       Toast t = Toast.makeText(this, " "+this.btnGravity.getText().toString(), Toast.LENGTH_SHORT);
        //alineacion,x,y
       t.setGravity(Gravity.TOP|Gravity.CENTER_HORIZONTAL,0,0);
       t.show();
    /*
        TOP
        Empuje el objeto hacia la parte superior de su contenedor, sin cambiar su tamaño.

        RIGHT
        Empuje el objeto hacia la derecha de su contenedor, sin cambiar su tamaño.

        LEFT
        Empuje el objeto hacia la izquierda de su contenedor, sin cambiar su tamaño.

        BOTTOM
        Empuje el objeto hacia el fondo de su contenedor, sin cambiar su tamaño.

        CENTER
        Coloque el objeto en el centro de su contenedor tanto en el eje vertical como en el horizontal, sin cambiar su tamaño.

        CENTER_HORIZONTAL
        Coloque el objeto en el centro horizontal de su contenedor, sin cambiar su tamaño.

        CENTER_VERTICAL
        Coloque el objeto en el centro vertical de su contenedor, sin cambiar su tamaño.
        */


    }


    public void crearToastPersonalizado(){
        //Se necesita crear un layout, con la estructura que se desea mostrar

        //Creamos el Toast
        Toast t = new Toast(this);
        LayoutInflater inflater = getLayoutInflater();
        View layout = inflater.inflate(
                R.layout.layout_toast_personalizado,
                (ViewGroup) findViewById(R.id.linearLayoutCuerpoToastExample)
        );

        TextView titulo = (TextView)layout.findViewById(R.id.textViewTituloToastExample);
        titulo.setText("Toast Personalizado Titulo");

        TextView cuerpo = (TextView)layout.findViewById(R.id.textViewCuerpoToastExample);
        cuerpo.setText("Toast Personalizado Cuerpo");

        t.setDuration(Toast.LENGTH_LONG);
        t.setView(layout);
        t.show();
    }

    @Override
    public void onClick(View v) {
        if (v == this.btnCorto)
            this.crearToastCorto();
            else if (v == this.btnLargo)
                this.crearToastLargo();
             else   if (v == this.btnGravity)
                 this.crearToastGravity();
                else    if (v == this.btnPersonalizado)
                    this.crearToastPersonalizado();
    }
}