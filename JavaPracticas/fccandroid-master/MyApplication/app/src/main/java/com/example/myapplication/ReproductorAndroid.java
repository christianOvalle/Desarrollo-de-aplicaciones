package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.FileProvider;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import java.io.File;

public class ReproductorAndroid extends AppCompatActivity implements View.OnClickListener {

    Button btn;
    //String rutaArchivo;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_reproductor_android);

        this.btn = (Button) this.findViewById(R.id.btnReproductorAndroidPlay);
        this.btn.setOnClickListener(this);
       // this.VerArchivos();
    }
    public void VerArchivos(){

        File file = this.getFilesDir();
        Log.d("ArchivosAndroid",file.getAbsolutePath());
        Log.d("ArchivosAndroid",file.getName());
        Log.d("ArchivosAndroid",file.getParent());
        Log.d("ArchivosAndroid",file.getPath());
        Log.d("ArchivosAndroid",String.valueOf(file.getUsableSpace()));
        Log.d("ArchivosAndroid",String.valueOf(file.getFreeSpace()));
        String[] archivos = this.fileList();
        Log.d("ArchivosAndroid",String.valueOf(archivos.length));
        for (String archivo : archivos ) {
            if (archivo.equals("gato.mp3"))
            Log.d("ArchivosAndroid", archivo);
            Toast.makeText(this, "Archivo "+archivo, Toast.LENGTH_SHORT).show();
        }
    }
    @Override
    public void onClick(View v) {
        try {

            //Acción mas básica, dependiendo de la aplicación que se llame se realizara algo diferente
            Intent intent = new Intent(android.content.Intent.ACTION_VIEW);

            //Ok
            Uri data = Uri.parse("https://www.tutorialesprogramacionya.com/recursos/gato.mp3");

            intent.setDataAndType(data, "audio/mp3");
            startActivity(intent);
        }catch (Exception e){
            Toast.makeText(this, ""+e.getMessage(), Toast.LENGTH_SHORT).show();
            Log.d("ArchivosAndroid",e.getMessage()+" | "+e.toString());
        }
    }
}

/*
* File archivo = new File(this.getFilesDir().getPath()+"/gato.mp3");
            Uri path = Uri.fromFile(archivo);
            Intent intent = new Intent(android.content.Intent.ACTION_VIEW);
            //Uri data = Uri.parse("file://"+this.getFilesDir().getPath().toString()+ "/gato.mp3");
            //Uri data = Uri.parse(getExternalFilesDir(null).toString()+ "/gato.mp3");
            Toast.makeText(this, getExternalFilesDir(null).toString()+" - "+this.getFilesDir().toString(), Toast.LENGTH_LONG).show();


            intent.setDataAndType(path, "audio/mp3");
            startActivity(intent);*
//Uri data = Uri.parse("file:///sdcard" + "/gato.mp3");
//Uri data = Uri.parse("file:///data/user/0/com.example.myapplication/files/gato.mp3");
//Uri data = Uri.parse("content:///sdcard/gallo.mp3");
//Uri data = Uri.parse("content://"+this.getFilesDir().getPath()+"/gallo.mp3");

            //Uri data = Uri.parse("android.resource://" + getPackageName() + "/raw/gallo.mp3");
            //Uri data = Uri.parse("android.resource://" + getPackageName() + "/"+R.raw.perro);

            //Uri data = Uri.parse("content:///data/user/0/com.example.myapplication/files/gato.mp3");

             //i.setAction(android.content.Intent.ACTION_VIEW);
            //intent.setDataAndType(Uri.fromFile(new File(this.getFilesDir().getPath()+"/gallo.mp3")), "audio/mp3");
            //intent.setFlags(Intent.FLAG_GRANT_READ_URI_PERMISSION);
            //intent.setFlags(Intent.FLAG_GRANT_READ_URI_PERMISSION);
            //intent.setDataAndType(FileProvider.getUriForFile(this,BuildConfig.APPLICATION_ID +".provider",new File(this.getFilesDir().getPath()+"/gallo.mp3")), "audio/mp3");
            //startActivity(intent);

Log.d("ArchivosAndroid",this.getFilesDir().getPath());


*/