package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class AgregarLenguaje extends AppCompatActivity implements View.OnClickListener {

    EditText UsuarioLenguaje;
    EditText UsuarioFecha;
    Button Guardar;
    LenguajesAdd lenguajesAdd = new LenguajesAdd();


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_agregar_lenguaje);

        this.UsuarioLenguaje = this.findViewById(R.id.editTextTextEmailAddress4);
        this.UsuarioFecha = this.findViewById(R.id.editTextTextEmailAddress5);
        this.Guardar = this.findViewById(R.id.button15);
        this.Guardar.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {

        lenguajesAdd.Menu.add(this.UsuarioLenguaje.getText().toString());
        lenguajesAdd.Creador.add(this.UsuarioFecha.getText().toString());
        this.finish();


    }
}