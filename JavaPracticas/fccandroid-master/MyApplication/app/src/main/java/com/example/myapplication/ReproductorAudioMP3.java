package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import java.io.IOException;

public class ReproductorAudioMP3 extends AppCompatActivity implements View.OnClickListener {

    Button btnReproductor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_reproductor_audio_m_p3);

        this.btnReproductor = this.findViewById(R.id.btnReproductorAudioMp3InternetPlay);
        this.btnReproductor.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        MediaPlayer mp = new MediaPlayer();
        try {
            mp.setDataSource("https://www.tutorialesprogramacionya.com/recursos/gato.mp3");
            mp.prepare();
            mp.start();
        } catch (IOException e) {
            Toast.makeText(this, "Mensaje "+e.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }
}