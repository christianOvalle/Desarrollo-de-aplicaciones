package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class XMLSheredPreferencesExample extends AppCompatActivity implements View.OnClickListener {

    /*
    *
    *   MODE_PRIVATE solo la aplicación puede acceder al archivo de preferencias.

        MODE_WORLD_READABLE otras aplicaciones pueden consultar el archivo de preferencias

        MODE_WORLD_WRITEABLE otras aplicaciones pueden consultar y modificar el archivo.

        MODE_MULTI_PROCESS varios procesos pueden acceder (Requiere Android 2.3)
    *
    * */

    EditText email;
    Button btnGuardarXML;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_x_m_l_shered_preferences_example);

        this.email = (EditText) this.findViewById(R.id.editTextEmailXML);
        this.btnGuardarXML = (Button) this.findViewById(R.id.btnGuardarEmailXML);
        this.btnGuardarXML.setOnClickListener(this);

        //SharePreferences Permite crear un archivo xml, en el modo privado para esta app
        SharedPreferences prefe=this.getSharedPreferences("archivoxaml", Context.MODE_PRIVATE);
        //getString (keyName, defaultValue)
        this.email.setText(prefe.getString("mail",""));

    }

    @Override
    public void onClick(View v) {
        SharedPreferences preferencias=getSharedPreferences("archivoxaml",Context.MODE_PRIVATE);
        SharedPreferences.Editor editor=preferencias.edit();//Editamos el archivo
        editor.putString("mail", this.email.getText().toString());
        editor.commit();//Guarda el archivo
        this.finish();//finaliza la activity
    }

    /*
    * editor.putInt("edad",3);
editor.putBoolean("activo", true);
editor.putFloat("altura", 2.3f);
*
* int e=prefe.getInt("edad", 0);
boolean acti=prefe.getBoolean("activo", false);
float alt=prefe.getFloat("altura", 0f);
    * */
}