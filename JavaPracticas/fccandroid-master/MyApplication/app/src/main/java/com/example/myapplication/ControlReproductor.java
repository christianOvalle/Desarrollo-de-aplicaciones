package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.os.Handler;
import android.view.View;
import android.widget.ImageView;
import android.widget.ProgressBar;
import android.widget.Toast;

public class ControlReproductor extends AppCompatActivity implements View.OnClickListener {

    ImageView imageViewPausa, imageViewPlay, imageViewDetener,
            imageViewReproduccionCircular, imageViewReanudar;
   // ProgressBar progressBar;
    MediaPlayer mp;
    int posicion = 0;
    boolean reproduccionCircular = false;

    //private Handler myHandler = new Handler();

    /*
    @Override
    protected void onStop() {
        super.onStop();
        //this.myHandler.removeCallbacks(UpdateSongTime);
        this.finish();
    }*/

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_control_reproductor);

       // this.progressBar = (ProgressBar) this.findViewById(R.id.progressBarControlReproductor);

        this.imageViewDetener = (ImageView) this.findViewById(R.id.imageViewControlReproductorDetener);
        this.imageViewReproduccionCircular = (ImageView) this.findViewById(R.id.imageViewControlReproductorCircular);
        this.imageViewPausa = (ImageView) this.findViewById(R.id.imageViewControlReproductorPausa);
        this.imageViewPlay = (ImageView) this.findViewById(R.id.imageViewControlReproductorPlay);
        this.imageViewReanudar = (ImageView) this.findViewById(R.id.imageViewControlReproductorReanudar);

        this.imageViewDetener.setOnClickListener(this);
        this.imageViewReproduccionCircular.setOnClickListener(this);
        this.imageViewPausa.setOnClickListener(this);
        this.imageViewPlay.setOnClickListener(this);
        this.imageViewReanudar.setOnClickListener(this);

        //this.progressBar.setVisibility(ProgressBar.INVISIBLE);

    }

    public void destruir() {
        if (mp != null)
            mp.release();
    }
    public void Play(){
        this.destruir();
        mp = MediaPlayer.create(this, R.raw.tritachyonkleptotonicswing);
        mp.start();
        this.mp.setLooping(this.reproduccionCircular);
        //myHandler.postDelayed(UpdateSongTime,100);
    }
    public void Pausar(){
        if (mp != null && mp.isPlaying())
            this.posicion = this.mp.getCurrentPosition();
            this.mp.pause();
           // this.myHandler.removeCallbacks(UpdateSongTime);
    }
    public void Reanudar(){
        if (this.mp != null && !this.mp.isPlaying())
            this.mp.seekTo(this.posicion);
        this.mp.start();
        //myHandler.postDelayed(UpdateSongTime,100);

    }
    public void Detener(){
        if (this.mp != null)
            this.mp.stop();
        this.posicion = 0;
        //this.myHandler.removeCallbacks(UpdateSongTime);

    }
    public void ReproduccionCircular(){
        this.reproduccionCircular = !this.reproduccionCircular;
        if (this.mp != null && !this.mp.isPlaying())
            this.mp.setLooping(this.reproduccionCircular);

    }

    @Override
    public void onClick(View v) {
        if (v == this.imageViewPlay)
            this.Play();
        else if(v == this.imageViewPausa)
            this.Pausar();
        else if (v == this.imageViewDetener)
            this.Detener();
        else if (v == this.imageViewReanudar)
            this.Reanudar();
        else if (v== this.imageViewReproduccionCircular)
            this.ReproduccionCircular();
    }


    /*
    private Runnable UpdateSongTime = new Runnable() {
        public void run() {
            //40/50 x 100 = 0.8 x 100 = 80%.
            int auxPosicion = mp.getCurrentPosition();
            int total = mp.getDuration();

            progressBar.setMax(100);
            float div = (auxPosicion/total);
            float aux = (div*100);
            int porcentaje = (int) (aux * 100);
            Toast.makeText(ControlReproductor.this, div+" - "+aux+" - "+" Porcentaje "+porcentaje+" Actual "+auxPosicion+" Total "+total, Toast.LENGTH_SHORT).show();

            progressBar.setProgress(porcentaje);
            myHandler.postDelayed(this, 100);
        }
    };*/
}