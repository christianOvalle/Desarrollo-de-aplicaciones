package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;

public class LenguajesAdd extends AppCompatActivity implements AdapterView.OnItemLongClickListener, View.OnClickListener{

    ArrayList<String> Creador = new ArrayList<>();
    ArrayList<String> Menu = new ArrayList<>();
    ListView Lengu;
    Button add;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lenguajes_list_view);

        this.Lengu = this.findViewById(R.id.Lenguajes3);
        this.add = this.findViewById(R.id.button19);
        this.add.setOnClickListener(this);
        this.Lengu.setOnItemLongClickListener(this);

        LlenarListaLenguajes();

    }

    public void LlenarListaLenguajes(){



        Menu.add("PHP");
        Menu.add("Java");
        Menu.add("Go");
        Menu.add("Kotlin");
        Menu.add("javascript");
        Menu.add("csharp");
        Menu.add("Visual");

        Creador.add("Creado por Rasmus Lerdorf en 1994");
        Creador.add("Creado por James Gosling en 1995");
        Creador.add("Creado por Robert Griesemer");
        Creador.add("Creador por Ken Thompson en 2009");
        Creador.add("Creado por JetBrains en 2016");
        Creador.add("Creado por Brendan Eich en 1995");
        Creador.add("Creado por Anders Hejlsberg Microsoft en 2000");

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1,this.Menu);
        Lengu.setAdapter(adapter);



    }


    @Override
    public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long l) {

        int PosicionLenguaje = i;
        String LenguajeSeleccionado = this.Lengu.getItemAtPosition(PosicionLenguaje).toString();
        String CreadorLenguaje = this.Creador.get(PosicionLenguaje);

        switch(PosicionLenguaje){

            case 0:
                Toast.makeText(this, "Lenguaje: "+LenguajeSeleccionado+" "+CreadorLenguaje, Toast.LENGTH_SHORT).show();
                break;
            case 1:
                Toast.makeText(this, "Lenguaje: "+LenguajeSeleccionado+" "+CreadorLenguaje, Toast.LENGTH_SHORT).show();
                break;
            case 2:
                Toast.makeText(this, "Lenguaje: "+LenguajeSeleccionado+" "+CreadorLenguaje, Toast.LENGTH_SHORT).show();
                break;
            case 3:
                Toast.makeText(this, "Lenguaje: "+LenguajeSeleccionado+" "+CreadorLenguaje, Toast.LENGTH_SHORT).show();
                break;
            case 4:
                Toast.makeText(this, "Lenguaje: "+LenguajeSeleccionado+" "+CreadorLenguaje, Toast.LENGTH_SHORT).show();
                break;
            case 5:
                Toast.makeText(this, "Lenguaje: "+LenguajeSeleccionado+" "+CreadorLenguaje, Toast.LENGTH_SHORT).show();
                break;
            case 6:
                Toast.makeText(this, "Lenguaje: "+LenguajeSeleccionado+" "+CreadorLenguaje, Toast.LENGTH_SHORT).show();
                break;
        }

        return true;
    }

    @Override
    public void onClick(View view) {

        Intent intent = new Intent(LenguajesAdd.this,AgregarLenguaje.class);
        startActivity(intent);

    }
}

