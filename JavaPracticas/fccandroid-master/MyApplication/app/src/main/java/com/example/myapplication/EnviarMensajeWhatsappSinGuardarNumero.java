package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class EnviarMensajeWhatsappSinGuardarNumero extends AppCompatActivity implements View.OnClickListener {

    EditText numero,mensaje;
    Button btnEnviar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_enviar_mensaje_whatsapp_sin_guardar_numero);

        this.numero = (EditText) this.findViewById(R.id.editTextPhoneNumeroWhatsapp);
        this.mensaje = (EditText) this.findViewById(R.id.editTextTextMultiLineMensajeWhatsapp);

        this.btnEnviar = (Button) this.findViewById(R.id.btnEnviarMensajeWhatsapp);
        this.btnEnviar.setOnClickListener(this);

        
    }

    @Override
    public void onClick(View v) {
        String telefono = this.numero.getText().toString();
        String mensaje = this.mensaje.getText().toString().replace(" ","%20");
        String url = "https://api.whatsapp.com/send?phone=1" + telefono+"&text="+mensaje;
        Uri uri = Uri.parse(url);
        //Uri uri = Uri.parse(" https://wa.me/1"+telefono+"?text="+mensaje+"");
        //Intent i = getPackageManager().getLaunchIntentForPackage("com.whatsapp");
        //i.setData(uri);
        Intent i = new Intent(Intent.ACTION_VIEW,uri);
        //i.setData(uri);
        this.startActivity(i);
    }
}