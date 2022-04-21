package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

public class RelativeLayoutExample extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_relative_layout_example);
    }



    /*

    Posición relativa a otro control:

    android:layout_above
    android:layout_below
    android:layout_toLeftOf
    android:layout_toRightOf
    android:layout_alignLeft
    android:layout_alignRight
    android:layout_alignTop
    android:layout_alignBottom
    android:layout_alignBaseline
    Posición relativa al layout padre:

    android:layout_alignParentLeft
    android:layout_alignParentRight
    android:layout_alignParentTop
    android:layout_alignParentBottom
    android:layout_centerHorizontal
    android:layout_centerVertical
    android:layout_centerInParent
    Por último indicar que cualquiera de los tipos de layout anteriores poseen otras propiedades comunes como por ejemplo los márgenes exteriores (margin) e interiores (padding) que pueden establecerse mediante los siguientes atributos:

    Opciones de margen exterior:

    android:layout_margin
    android:layout_marginBottom
    android:layout_marginTop
    android:layout_marginLeft
    android:layout_marginRight
    Opciones de margen interior:

    android:padding
    android:paddingBottom
    android:paddingTop
    android:paddingLeft
    android:paddingRight

    * */
}