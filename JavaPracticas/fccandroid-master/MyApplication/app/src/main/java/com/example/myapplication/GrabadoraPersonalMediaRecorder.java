package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.media.MediaRecorder;
import android.os.Bundle;
import android.os.Environment;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.io.File;
import java.io.IOException;

public class GrabadoraPersonalMediaRecorder extends AppCompatActivity implements View.OnClickListener, MediaPlayer.OnCompletionListener {

    /*
    *
    <uses-permission android:name="android.permission.RECORD_AUDIO" />
    <uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
    * */

    /*
    * Nota no funciona en el emulador
    * */
    Button btnGrabar,btnReproducir,btnDetener;
    TextView textView;

    //Declaramos un objeto de la clase MediaRecorder para grabar audio:
    MediaRecorder recorder;
    //Declaramos un objeto de la clase MediaPlayer para reproducir el archivo de sonido generado:
    MediaPlayer player;
    //Declaramos un objeto de la clase File que hace referencia al archivo que se creará:
    File archivo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_grabadora_personal_media_recorder);

        this.btnDetener = (Button) this.findViewById(R.id.btnGrabadoraPersonalMediaRecorderDetenerReproduccion);
        this.btnGrabar = (Button) this.findViewById(R.id.btnGrabadoraPersonalMediaRecorderGrabar);
        this.btnReproducir = (Button) this.findViewById(R.id.btnGrabadoraPersonalMediaRecorderReproducirGrabacion);

        this.textView = (TextView) this.findViewById(R.id.textViewGrabadoraPersonalMediaRecorderLabel);

        this.btnDetener.setOnClickListener(this);
        this.btnGrabar.setOnClickListener(this);
        this.btnReproducir.setOnClickListener(this);
        Log.d("ArchivosAndroid","OnCreate");
    }


    public void grabar() {
        Log.d("ArchivosAndroid","Grabar");
        this.recorder = new MediaRecorder();
        try {
                //Seguidamente definimos el micrófono como fuente de audio:
                recorder.setAudioSource(MediaRecorder.AudioSource.MIC);
                //Luego llamamos al método setOutputFormat especificando que el archivo
                // será almacenado con la especificación 3GPP y con extensión .3gp
                recorder.setOutputFormat(MediaRecorder.OutputFormat.THREE_GPP);
                //Especificamos el codec a emplear llamando al método setAudioEncoder:
                recorder.setAudioEncoder(MediaRecorder.AudioEncoder.AMR_NB);


                //Obtenemos el path de la tarjeta SD y creamos un archivo temporal con extensión 3gp:
            //La clase Java.io.File es una representación abstracta de nombres de rutas de archivos y directorios
            //File representara el espacio en la SD
                File path = new File(Environment.getExternalStorageDirectory()
                        .getPath());
                //getPath() Este método convierte este nombre de ruta abstracto en una cadena de nombre de ruta.

            Log.d("ArchivosAndroid","Creamos le temporal file");
                    /*
                    * prefijo : la cadena de prefijo define el nombre del archivo; debe tener al menos tres caracteres
                    * sufijo : la cadena de sufijo define la extensión del archivo; si es nulo se usará el sufijo ".tmp"
                    * directorio : el directorio en el que se creará el archivo. Para el directorio de archivos temporales predeterminado, se debe pasar nulo
                    * */
                    this.archivo = File.createTempFile("temporal", ".3gp", path);
        } catch (IOException e) {
            Log.d("ArchivosAndroid",e.getMessage());
        }
        //Con el método setOutputFile de la clase MediaRecorder
        //
        // le indicamos el archivo donde debe almacenarse la grabación:
        this.recorder.setOutputFile(this.archivo.getAbsolutePath());
        //Llamamos al método prepare y finalmente al método start para comenzar la grabación:
        try {
            //Preparamos todo para la grabacion
            this.recorder.prepare();
        } catch (IOException e) {
            Log.d("ArchivosAndroid",e.getMessage());
        }
        //Iniciamos la grabacion
        this.recorder.start();
        this.textView.setText("Grabando");
        this.btnGrabar.setEnabled(false);
        this.btnDetener.setEnabled(true);
    }

    public void detener() {
        //Llamamos primero al método stop de la clase MediaRecorder y liberamos los recursos consumidos llamando a release:
        recorder.stop();
        recorder.release();

        player = new MediaPlayer();
        //Indicamos mediante el método setOnCompletionListener la referencia de la clase que será informada cuando el audio finalice:
        player.setOnCompletionListener(this);
        try {
            //Referenciamos el archivo a que debe reproducir:
            player.setDataSource(this.archivo.getAbsolutePath());
        } catch (IOException e) {
            Log.d("ArchivosAndroid",e.getMessage());
        }
        try {
            //Finalmente llamamos al método prepare de la clase MediaPlayer:
            player.prepare();
        } catch (IOException e) {
            Log.d("ArchivosAndroid",e.getMessage());
        }
        this.btnGrabar.setEnabled(true);
        this.btnDetener.setEnabled(false);
        this.btnReproducir.setEnabled(true);
        this.textView.setText("Listo para reproducir");
    }

    public void reproducir() {
        player.start();
        this.btnGrabar.setEnabled(false);
        this.btnDetener.setEnabled(false);
        this.btnReproducir.setEnabled(false);
        this.textView.setText("Reproduciendo");
    }


    @Override
    public void onClick(View v) {
            if (v == this.btnGrabar)
                this.grabar();
            else if (v==this.btnDetener)
                this.detener();
            else if (v==this.btnReproducir)
                this.reproducir();
    }

    @Override
    public void onCompletion(MediaPlayer mp) {
        this.btnGrabar.setEnabled(true);
        this.btnDetener.setEnabled(true);
        this.btnReproducir.setEnabled(true);
        this.textView.setText("Listo");
    }
}