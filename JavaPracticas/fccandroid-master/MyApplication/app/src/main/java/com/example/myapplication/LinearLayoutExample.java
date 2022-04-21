package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;

public class LinearLayoutExample extends AppCompatActivity implements View.OnClickListener {

    private LinearLayout linearLayoutOrientacion;
    private Button btnCambiarOrientacion;
    private boolean defaultOrientacion = true;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_linear_layout_example);

        this.linearLayoutOrientacion = (LinearLayout) this.findViewById(R.id.linearLayoutControlOrientacion);
        this.btnCambiarOrientacion = (Button) this.findViewById(R.id.btnLinearLayoutExampleCambiarOrientacion);

        this.btnCambiarOrientacion.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        this.defaultOrientacion = !this.defaultOrientacion;
        if (defaultOrientacion)
            this.linearLayoutOrientacion.setOrientation(LinearLayout.HORIZONTAL);
        else
            this.linearLayoutOrientacion.setOrientation(LinearLayout.VERTICAL);
    }
}