package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

public class LenguajesListView extends AppCompatActivity implements AdapterView.OnItemLongClickListener {



    String[] Menu = {"PHP","JAVA","Go","Kotlin","javascript","csharp","visual basic"};
    String[] Creadores = {"Creado por Rasmus Lerdorf en 1994","Creado por James Gosling en 1995","Creado por Robert Griesemer", "Creador por Ken Thompson en 2009","Creado por JetBrains en 2016","Creado por Brendan Eich en 1995","Creado por Anders Hejlsberg Microsoft en 2000"};
    ListView Lengu;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lenguajes_list_view);

        this.Lengu = this.findViewById(R.id.Lenguajes3);
        this.Lengu.setOnItemLongClickListener(this);

        LlenarListaLenguajes();

    }

    public void LlenarListaLenguajes(){

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1,this.Menu);
        Lengu.setAdapter(adapter);

    }


    @Override
    public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long l) {

        int PosicionLenguaje = i;
        String LenguajeSeleccionado = this.Lengu.getItemAtPosition(PosicionLenguaje).toString();
        String CreadorLenguaje = this.Creadores[PosicionLenguaje];

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
}