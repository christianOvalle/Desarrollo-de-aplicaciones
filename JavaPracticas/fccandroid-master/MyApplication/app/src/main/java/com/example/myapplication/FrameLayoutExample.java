package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

public class FrameLayoutExample extends AppCompatActivity implements View.OnClickListener {

    private Button btnLlamar;
    private ImageView imageViewLlamando;
    boolean visibilidad=true;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_frame_layout_example);

        this.btnLlamar = (Button) this.findViewById(R.id.btnFrameLayoutExampleVisibilidad);
        this.imageViewLlamando = (ImageView) this.findViewById(R.id.imageViewFrameLayoutExampleIconoLlamar);

        this.btnLlamar.setOnClickListener(this);
        this.imageViewLlamando.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        this.visibilidad = !this.visibilidad;
        if (this.visibilidad) {
            this.btnLlamar.setVisibility(Button.VISIBLE);
            this.imageViewLlamando.setVisibility(ImageView.INVISIBLE);
        }else{
            this.btnLlamar.setVisibility(Button.INVISIBLE);
            this.imageViewLlamando.setVisibility(ImageView.VISIBLE);
        }
    }

    /*
    * El control de tipo FrameLayout dispone dentro del contenedor todos los controles visuales alineados al vértice superior izquierdo,centrado, vértice inferior derecho etc. (tiene nueve posiciones posibles).
Si disponemos dos o más controles los mismos se apilan.

Por ejemplo si disponemos dentro de un FrameLayout un ImageView y un Button luego el botón se superpone a la imagen.
    * */
}