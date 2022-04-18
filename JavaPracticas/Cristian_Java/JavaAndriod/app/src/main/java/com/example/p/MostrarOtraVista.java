package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MostrarOtraVista extends AppCompatActivity implements View.OnClickListener {

    EditText Palabra;
    Button Search;




    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mostrar_otra_vista);

        this.Palabra = this.findViewById(R.id.editTextTextEmailAddress);

        this.Search = this.findViewById(R.id.button11);
        this.Search.setOnClickListener(this);

    }

    @Override
    public void onClick(View view) {

        Toast.makeText(this, "Clic a buscar", Toast.LENGTH_SHORT).show();

        Intent intent = new Intent(this,ResultadoBusqueda.class);
        intent.putExtra("PalabraAbuscar",this.Palabra.getText().toString());

        startActivity(intent);
    }
}