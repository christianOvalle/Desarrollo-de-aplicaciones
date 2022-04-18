package com.example.p;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.webkit.WebView;
import android.widget.Button;

public class ResultadoBusqueda extends AppCompatActivity implements View.OnClickListener {


    WebView Web;
    Button FinalizarActivity;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_resultado_busqueda);

        this.Web = this.findViewById(R.id.Web1);
        this.FinalizarActivity = this.findViewById(R.id.button12);

        this.FinalizarActivity.setOnClickListener(this);

        Bundle bundle = getIntent().getExtras();
        String Palabra = bundle.getString("PalabraAbuscar");
        this.Web.loadUrl("https://"+Palabra);
    }

    @Override
    public void onClick(View view) {
        this.finish();

    }
}