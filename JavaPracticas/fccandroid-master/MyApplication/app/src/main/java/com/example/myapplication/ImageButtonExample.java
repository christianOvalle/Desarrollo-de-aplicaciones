package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

public class ImageButtonExample extends AppCompatActivity {


    /*
    * Comentarios extras de este control.
Cuando copiamos el archivo lo hicimos a la carpeta:

mipmap-mdpi
Pero vimos que hay otras carpetas con nombres similares:


mipmap-mdpi
mipmap-hdpi
mipmap-xhdpi
mipmap-xxhdpi
mipmap-xxxhdpi
mipmap-anydpi-v26
El objetivo de estas otras carpetas es guardar las mismas imágenes pero con una resolución mayor si la guardamos en mipmap-hdpi.

Esto se hace si queremos que nuestra aplicación sea más flexible si se ejecuta en un celular, en una tablet, en un televisor etc.

Debemos tener en cuenta estos tamaños:

En la carpeta res/mipmap-mdpi/
(guardamos la imagen con el tamaño original)

En la carpeta res/mipmap-hdpi/
(guardamos la imagen con el tamaño del 150% con respecto al de la carpeta mipmap-mdpi)

En la carpeta res/mipmap-xhdpi/
(guardamos la imagen con el tamaño del 200% con respecto al de la carpeta mipmap-mdpi)

En la carpeta res/mipmap-xxhdpi/
(guardamos la imagen con el tamaño del 300% con respecto al de la carpeta mipmap-mdpi)

En la carpeta res/mipmap-xxxhdpi/
(guardamos la imagen con el tamaño del 400% con respecto al de la carpeta mipmap-mdpi)

En la carpeta res/mipmap-anydpi-v26/
(en las últimas versiones de android nos permite disponer íconos adaptativos que
reemplacen a los archivios png o jpg, con la ventaja que nuestra aplicación será más liviana)
    * */

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_image_button_example);
    }

    public void EjemploMetodo(View v){
        Toast.makeText(this, "Mensaje", Toast.LENGTH_SHORT).show();

    }

}