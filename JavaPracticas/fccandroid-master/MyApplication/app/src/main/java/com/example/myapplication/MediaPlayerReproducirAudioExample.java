package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;

import java.util.HashMap;
import java.util.Map;

public class MediaPlayerReproducirAudioExample extends AppCompatActivity implements View.OnClickListener {

    /*
    * Formatos
    * Ogg, Wav, mp3
     * */

    HashMap<String, Integer> mp3Raw = new HashMap<String, Integer>() ;

    private ImageView imgView1,imgView2,imgView3,imgView4,imgView5,imgView6,
            imgView7,imgView8,imgView9,imgView10,imgView11;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_media_player_reproducir_audio_example);
        this.agregarReferenciasMp3Raw();
        this.agregarReferencias();
        this.agregarListener();
    }
    public void agregarReferenciasMp3Raw(){

        this.mp3Raw.put("gallo",R.raw.gallo);
        this.mp3Raw.put("burro",R.raw.burro);
        this.mp3Raw.put("caballo",R.raw.caballo);
        this.mp3Raw.put("elefante",R.raw.elefante);
        this.mp3Raw.put("gato",R.raw.gato);
        this.mp3Raw.put("leon",R.raw.leon);
        this.mp3Raw.put("lobo",R.raw.lobo);
        this.mp3Raw.put("mono",R.raw.mono);
        this.mp3Raw.put("pajaro",R.raw.pajaro);
        this.mp3Raw.put("perro",R.raw.perro);
        this.mp3Raw.put("vaca",R.raw.vaca);
    }

    public void agregarReferencias(){
        this.imgView1 = (ImageView) this.findViewById(R.id.imageViewBurro);
        this.imgView2 = (ImageView) this.findViewById(R.id.imageViewCaballo);
        this.imgView3 = (ImageView) this.findViewById(R.id.imageViewElefante);
        this.imgView4 = (ImageView) this.findViewById(R.id.imageViewGallo);
        this.imgView5 = (ImageView) this.findViewById(R.id.imageViewGato);
        this.imgView6 = (ImageView) this.findViewById(R.id.imageViewLeon);
        this.imgView7 = (ImageView) this.findViewById(R.id.imageViewLobo);
        this.imgView8 = (ImageView) this.findViewById(R.id.imageViewMono);
        this.imgView9 = (ImageView) this.findViewById(R.id.imageViewPajaro);
        this.imgView10 = (ImageView) this.findViewById(R.id.imageViewPerro);
        this.imgView11 = (ImageView) this.findViewById(R.id.imageViewVaca);
    }
    public void agregarListener(){
        this.imgView1.setOnClickListener(this);
        this.imgView2.setOnClickListener(this);
        this.imgView3.setOnClickListener(this);
        this.imgView4.setOnClickListener(this);
        this.imgView5.setOnClickListener(this);
        this.imgView6.setOnClickListener(this);
        this.imgView7.setOnClickListener(this);
        this.imgView8.setOnClickListener(this);
        this.imgView9.setOnClickListener(this);
        this.imgView10.setOnClickListener(this);
        this.imgView11.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        ImageView imagenCliqueada = (ImageView) v;
        String nombreMP3 = imagenCliqueada.getContentDescription().toString();
        MediaPlayer mp = MediaPlayer.create(this,  this.mp3Raw.get(nombreMP3));
        mp.start();
    }
}