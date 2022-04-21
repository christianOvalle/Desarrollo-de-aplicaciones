package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class ReproducirAudioMemoriaExterna extends AppCompatActivity implements View.OnClickListener {

    //<uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE" />
    Button btnPlay;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_reproducir_audio_memoria_externa);

        this.btnPlay = (Button) this.findViewById(R.id.btnReproducirAudioMemoriaExternaReproducir);
        this.btnPlay.setOnClickListener(this);
    }

    public void Play() {
        /*Analiza el identificador URI de la instancia actual para garantizar que contiene todas las partes requeridas para que un URI sea válido.
        * */
        /*
        * create(Context, Uri)
        *
        * */
        Uri datos = Uri.parse(getExternalFilesDir(null).toString() + "/gato.mp3");
        MediaPlayer mp = MediaPlayer.create(this,datos);
        mp.start();
    }

    @Override
    public void onClick(View v) {
        this.Play();
    }
}