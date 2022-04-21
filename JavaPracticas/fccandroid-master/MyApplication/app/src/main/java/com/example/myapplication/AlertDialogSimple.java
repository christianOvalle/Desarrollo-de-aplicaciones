package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.app.AlertDialog;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class AlertDialogSimple extends AppCompatActivity implements View.OnClickListener {


    //https://developer.android.com/guide/topics/ui/dialogs?hl=es-419

    Button btn;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_alert_dialog_simple);


        this.btn = (Button) this.findViewById(R.id.btnAlertDialogSimpleMostrar);
        this.btn.setOnClickListener(this);
    }

    public void CrearAlertDialog(){
        //Construir el AlertDialog
        AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
        alertDialog.setTitle("Titulo Alert Dialog");
        alertDialog.setMessage("Mensaje Alert Dialog");
        alertDialog.show();
    }

    @Override
    public void onClick(View v) {
        this.CrearAlertDialog();
    }
}