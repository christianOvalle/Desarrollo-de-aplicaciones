package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

//https://developer.android.com/reference/android/widget/AdapterView.OnItemLongClickListener

public class ListViewExample extends AppCompatActivity implements AdapterView.OnItemClickListener, AdapterView.OnItemLongClickListener {
    private String[] paises = { "Argentina", "Chile", "Paraguay", "Bolivia",
            "Peru", "Ecuador", "Brasil", "Colombia", "Venezuela", "Uruguay" };
    private String[] habitantes = { "40000000", "17000000", "6500000",
            "10000000", "30000000", "14000000", "183000000", "44000000",
            "29000000", "3500000" };

    TextView label1;
    ListView listView1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_list_view_example);

        this.label1 = (TextView) this.findViewById(R.id.textViewCantidadPoblacionPais);
        this.listView1 = (ListView) this.findViewById(R.id.listVIewPaises);

        this.listView1.setOnItemClickListener(this);
        this.LlenarListVIew();

        /* Evento click forma corta
        this.listView1.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

            }
        });*/
        this.listView1.setOnItemLongClickListener(this);
    }

    public void LlenarListVIew(){
        ArrayAdapter<String> adapter =
                new ArrayAdapter<String>(this,android.R.layout.simple_list_item_1, paises);
        this.listView1.setAdapter(adapter);
    }

    @Override
    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
        int indexDelListviewPais = position;
        String tituloItemListViewPais = this.listView1.getItemAtPosition(indexDelListviewPais).toString();
        String totalHabitantesPaisSeleccionado = this.habitantes[indexDelListviewPais];

        this.label1.setText("Poblacion de "+tituloItemListViewPais+" es: "+totalHabitantesPaisSeleccionado);

    }

    @Override
    public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {
        String auxHabitantes = this.habitantes[position];
        Toast.makeText(this, "Item Long Clic "+this.listView1.getItemAtPosition(position).toString()+" - "+auxHabitantes, Toast.LENGTH_LONG).show();
        return true;
    }
}