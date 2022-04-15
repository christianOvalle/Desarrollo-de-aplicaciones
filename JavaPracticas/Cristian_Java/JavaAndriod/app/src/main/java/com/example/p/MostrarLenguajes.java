package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.Toast;

public class MostrarLenguajes extends AppCompatActivity  {


        private CheckBox Java;
        private CheckBox JavaScript;
        private CheckBox Go;
        private CheckBox Kotlin;
        private CheckBox Python;
        private CheckBox C_Cplusplus;
        private CheckBox Scala;
        private CheckBox Ruby;
        private CheckBox Swift;
        private CheckBox Dart;
        private Button Ver;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mostrar_lenguajes);

        this.Java = this.findViewById(R.id.checkBox24);
        this.JavaScript = this.findViewById(R.id.checkBox23);
        this.Go = this.findViewById(R.id.checkBox22);
        this.Kotlin = this.findViewById(R.id.checkBox21);
        this.Python = this.findViewById(R.id.checkBox20);
        this.C_Cplusplus = this.findViewById(R.id.checkBox19);
        this.Scala = this.findViewById(R.id.checkBox18);
        this.Ruby = this.findViewById(R.id.checkBox17);
        this.Swift = this.findViewById(R.id.checkBox16);
        this.Dart = this.findViewById(R.id.checkBox7);

        this.Ver = this.findViewById(R.id.button9);

        this.Ver.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                String Lenguajes = "";
                if(Java.isChecked()){
                    Lenguajes = "1. "+Java.getText();

                }
                if(JavaScript.isChecked()){
                    Lenguajes+= ", " +"2. "+JavaScript.getText();

                }
                if(Go.isChecked()){
                    Lenguajes+=", " +"3."+Go.getText();

                }
                if(Kotlin.isChecked()){
                    Lenguajes+= ", " +"4."+Kotlin.getText();

                }
                if(Python.isChecked()){
                    Lenguajes+= ", " +"5."+Python.getText();

                }
                if(C_Cplusplus.isChecked()){
                    Lenguajes+=", " + "6."+C_Cplusplus.getText();

                }
                if(Scala.isChecked()){
                    Lenguajes+=", " + "7."+Scala.getText();

                }
                if(Ruby.isChecked()){
                    Lenguajes+= ", " +"8."+Ruby.getText();

                }
                if(Swift.isChecked()){
                    Lenguajes+= ", " +"9."+Swift.getText();

                }
                if(Dart.isChecked()){
                    Lenguajes+= ", " +"10."+Dart.getText();

                }

                Toast.makeText(MostrarLenguajes.this, Lenguajes+"", Toast.LENGTH_SHORT).show();


            }
        });
    }
}