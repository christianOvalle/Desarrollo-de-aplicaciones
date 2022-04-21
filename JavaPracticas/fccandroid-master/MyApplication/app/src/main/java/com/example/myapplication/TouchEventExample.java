package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.view.MotionEventCompat;

import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

public class TouchEventExample extends AppCompatActivity implements View.OnTouchListener {

    //https://developer.android.com/training/graphics/opengl/touch?hl=es-419
    ImageView imgAnimales;
    TextView accion,coordenada;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_touch_event_example);

        this.imgAnimales = (ImageView) this.findViewById(R.id.imageView2);
        this.imgAnimales.setOnTouchListener(this);

        this.accion = (TextView) this.findViewById(R.id.textView4);
        this.coordenada = (TextView) this.findViewById(R.id.textView5);

    }

    @Override
    public boolean onTouch(View v, MotionEvent event) {
        //https://developer.android.com/reference/android/view/MotionEvent?hl=es-419
        boolean seRealizoEvento = true;
        switch (event.getActionMasked()){
            //presionamos la pantalla y no movemos el puntero hacia ningún lado
            case MotionEvent.ACTION_DOWN:
                Log.d("ArchivosAndroid","La accion ha sido ABAJO");

                //Toast.makeText(this, "La accion ha sido ABAJO", Toast.LENGTH_SHORT).show();
                this.accion.setText("La accion ha sido ABAJO");
                this.imgAnimales.setImageResource(R.drawable.caballo);
                break;
            //Pulsar y movernos
            case MotionEvent.ACTION_MOVE:
                Log.d("ArchivosAndroid","X "+event.getX()+" Y "+event.getY());
                Log.d("ArchivosAndroid","La accion ha sido MOVER");
                //Toast.makeText(this, "La accion ha sido MOVER", Toast.LENGTH_SHORT).show();
                this.accion.setText("La accion ha sido MOVER");
                this.coordenada.setText("X "+event.getX()+" Y "+event.getY());
                break;

            //Al levantar el dedo
            case MotionEvent.ACTION_UP:
                Log.d("ArchivosAndroid","La accion ha sido ARRIBA");

                //Toast.makeText(this, "La accion ha sido ARRIBA", Toast.LENGTH_SHORT).show();
                this.accion.setText("La accion ha sido ARRIBA");
                this.imgAnimales.setImageResource(R.drawable.burro);
                break;

        }
        return seRealizoEvento;
        /*
        * ACTION_DOWN:
            Este evento se dá cuando pulsamos la pantalla, es decir, presionamos la pantalla y no movemos el puntero hacia ningún lado.

            ACTION_MOVE:
            Este evento se dá cuando tras pulsar la pantalla, procedemos a mover el puntero por ella, es decir, cuando hagamos esto surgirán 2 eventos, el ACTION_DOWN y a continuación al mover el puntero aparecerá el evento ACTION_MOVE.

            ACTION_UP:
            Este evento se dá cuando levantamos el dedo o puntero de la pantalla, para que se dé este evento debe haberse dado anteriormente el evento ACTION_DOWN.

            ACTION_CANCEL:
            Este evento se dá cuando el gesto actual ha sido abortado y no recibamos ningún punto mas de el. En este ejemplo no nos surgirá este evento, pero es bueno considerarlo en futuras implementaciones, ya que se puede tratar como un ACTION_UP pero sin realizar tareas que normalmente realizaríamos.

            ACTION_OUTSIDE:
            Este evento se dá cuando el evento ocurre fuera de los límites normales de un elemento de la UI.
        *
        *
                        //Cuando el touch es interrumpido
            case MotionEvent.ACTION_CANCEL:
                Log.d("ArchivosAndroid","La accion ha sido CANCEL");

                //Toast.makeText(this, "La accion ha sido CANCEL", Toast.LENGTH_SHORT).show();
                this.accion.setText("La accion ha sido CANCEL");
                break;

            case MotionEvent.ACTION_OUTSIDE:
                Log.d("ArchivosAndroid","La accion ha sido fuera del elemento de la pantalla");

                //Toast.makeText(this, "La accion ha sido fuera del elemento de la pantalla", Toast.LENGTH_SHORT).show();
                this.accion.setText("La accion ha sido fuera del elemento de la pantalla");

                break;
            default:
                seRealizoEvento = false;

                //Toast.makeText(this, "Default", Toast.LENGTH_SHORT).show();
                this.accion.setText("Default");
                break;
        * */
    }
}