package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class AlertDialogBotones extends AppCompatActivity implements View.OnClickListener {

    //https://developer.android.com/guide/topics/ui/dialogs?hl=es-419

    Button btn;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_alert_dialog_botones);

        //btnAlertDialogBotonesMostrar
        this.btn = (Button) this.findViewById(R.id.btnAlertDialogBotonesMostrar);
        this.btn.setOnClickListener(this);
    }
    public void CrearAlertDialog(){
        //Crearemos una especie de confirma dialog
        //Construir el AlertDialog
        AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
        alertDialog.setTitle("Titulo Confirmar");
        alertDialog.setMessage("¿Desea salir de la activity?");
        //Ahora implementaremos los eventos con una clase anonima

        alertDialog.setPositiveButton(android.R.string.yes, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                finish();
            }
        });

        alertDialog.setNegativeButton(android.R.string.no, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                Toast.makeText(AlertDialogBotones.this, "Se ha elegido la opcion negativa", Toast.LENGTH_SHORT).show();
            }
        });

        alertDialog.show();
    }

    @Override
    public void onClick(View v) {
        this.CrearAlertDialog();
    }
}