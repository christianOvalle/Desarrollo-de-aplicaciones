package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.Toast;

public class Years extends AppCompatActivity implements View.OnClickListener {

     Spinner Lista;
     Button Ver;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_years);


        this.Ver = this.findViewById(R.id.button8);
        this.Ver.setOnClickListener(this);
        this.Lista = this.findViewById(R.id.spinner);

        String[] Numeros = {"1980", "1981","1982","1983","1984","1985","1986","1987","1988","1989","1990","1991","1992","1993","1994","1995","1996","1997","1998","1999","2000","2001","2002","2003","2004","2005","2006","2007","2008","2009","2010","2011","2012","2013","2014","2015","2016","2017","2018","2019","2020","2021","2022"};

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_item, Numeros);
        Lista.setAdapter(adapter);


    }

    @Override
    public void onClick(View view) {
       String Valor = this.Lista.getSelectedItem().toString();
        Toast.makeText(this, Valor+"", Toast.LENGTH_SHORT).show();
    }
}