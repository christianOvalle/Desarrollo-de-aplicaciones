package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

public class ImageButon extends AppCompatActivity {


    private View Play;
    private View Stop;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_image_buton);


        this.Play = this.findViewById(R.id.imageButton2);
        this.Stop = this.findViewById(R.id.imageButton);

        this.Play.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Toast.makeText(ImageButon.this, "Play", Toast.LENGTH_SHORT).show();

            }
        });

        this.Stop.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Toast.makeText(ImageButon.this, "Stop", Toast.LENGTH_SHORT).show();

            }
        });

    }
    }

