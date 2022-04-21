package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.Toast;

public class CheckBoxExample extends AppCompatActivity implements View.OnClickListener {

    Button btnVerSelecciona;
    CheckBox checkBoxPHP,checkBoxJava,checkBoxSharp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_check_box_example);

        this.AsignarComponente();
        this.AsignarListener();
    }


    public void AsignarComponente(){
        this.checkBoxJava = (CheckBox) this.findViewById(R.id.checkBoxJAVA);
        this.checkBoxPHP = (CheckBox) this.findViewById(R.id.checkBoxPHP);;
        this.checkBoxSharp = (CheckBox) this.findViewById(R.id.checkBoxCSharp);;

        this.btnVerSelecciona = (Button) this.findViewById(R.id.btnSeleccionLenguaje);
    }
    public void AsignarListener(){
        this.btnVerSelecciona.setOnClickListener(this);
    }


    @Override
    public void onClick(View v) {
        String lenguajeSeleccionado = " ";

        if (this.checkBoxSharp.isChecked())
            lenguajeSeleccionado += ","+this.checkBoxSharp.getText().toString();
        if (this.checkBoxPHP.isChecked())
            lenguajeSeleccionado += ","+this.checkBoxPHP.getText().toString();
        if (this.checkBoxJava.isChecked())
            lenguajeSeleccionado += ","+this.checkBoxJava.getText().toString();

        Toast.makeText(this, "Lenguaje seleccionado : "+lenguajeSeleccionado, Toast.LENGTH_LONG).show();

    }
}