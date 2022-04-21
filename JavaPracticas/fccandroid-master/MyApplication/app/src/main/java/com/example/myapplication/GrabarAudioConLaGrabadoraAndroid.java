package com.example.myapplication;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import android.app.Activity;
import android.content.Intent;
import android.media.MediaPlayer;
import android.media.MediaPlayer.OnCompletionListener;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
//Activity
//AppCompatActivity
public class GrabarAudioConLaGrabadoraAndroid extends Activity implements View.OnClickListener,OnCompletionListener  {

    Button btnGrabar,btnReproducir;
    public static int RECORD_REQUEST = 0;//Codigo para identificar la respuesta de nuestra activity
    Uri audioFileUri;//Ruta del archivo de audio que se grabara

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_grabar_audio_con_la_grabadora_android);

        this.btnGrabar = (Button) this.findViewById(R.id.btnGrabarAudioConLaGrabadoraAndroidGrabar);
        this.btnReproducir = (Button) this.findViewById(R.id.btnGrabarAudioConLaGrabadoraAndroidReproducir);

        this.btnGrabar.setOnClickListener(this);
        this.btnReproducir.setOnClickListener(this);

        //Desactivamos el boton de reproducir
        btnReproducir.setEnabled(false);
        Log.d("ArchivosAndroid","onCreate");

    }
    public void grabar(){
        try {
            //Creamos un intent, para abrir la grabadora
            Intent intent = new Intent(  MediaStore.Audio.Media.RECORD_SOUND_ACTION);
            //onActivityResult
            //Iniciamos el reproductor, le pasamos un identificador
            startActivityForResult(intent, RECORD_REQUEST);

            Log.d("ArchivosAndroid","grabar");
        }catch (Exception e){
            Log.d("ArchivosAndroid",e.getMessage());
        }
    }
    public void reproducir(){
        try {

            //Creamos nuestro reproductor
            MediaPlayer mediaPlayer = MediaPlayer.create(this, audioFileUri);
            //Escuchamos al reproductor para saber cuando termina la reproducion
            mediaPlayer.setOnCompletionListener(this);
            //Iniciamos la reproduccion
            mediaPlayer.start();
            //Desactivamos el boton de reproducir
            this.btnReproducir.setEnabled(false);
            Log.d("ArchivosAndroid","reproducir");

        }catch (Exception e){
            Log.d("ArchivosAndroid",e.getMessage());
        }
    }


    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {

        //Validamos que todo este OK
        if (resultCode == RESULT_OK && requestCode == RECORD_REQUEST) {
            //Obtenemos el URI con el archivo grabado
            audioFileUri = data.getData();
            //Habilitamos el boton de reproduccion
            this.btnReproducir.setEnabled(true);

            Log.d("ArchivosAndroid","onActivityResult");
        }
        Log.d("ArchivosAndroid","Fuera onActivityResult");
    }

    @Override
    public void onClick(View v) {
        if (v == this.btnGrabar)
            this.grabar();
        else if(v == this.btnReproducir)
            this.reproducir();
    }

    @Override
    public void onCompletion(MediaPlayer mp) {
        this.btnReproducir.setEnabled(true);
        Log.d("ArchivosAndroid","onCompletion");
    }




}



