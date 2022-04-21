package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class BuscadorWeb extends AppCompatActivity implements View.OnClickListener {

    EditText palabraGoogle;
    Button btnBuscarGoogle;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_buscador_web);

        this.palabraGoogle = (EditText) this.findViewById(R.id.editTextPalabrasEnGoogle);

        this.btnBuscarGoogle = (Button) this.findViewById(R.id.button5);

       // Toast.makeText(this, "Asignar", Toast.LENGTH_SHORT).show();
        this.btnBuscarGoogle.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {

        Toast.makeText(this, "Clic a uno de los botones", Toast.LENGTH_SHORT).show();


        Intent intent = new Intent(this,ResultadoBuscadorWeb.class);
        intent.putExtra("palabragoogle", this.palabraGoogle.getText().toString());

        startActivity(intent);
    }
}