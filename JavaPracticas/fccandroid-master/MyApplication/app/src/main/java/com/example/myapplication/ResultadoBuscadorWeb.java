package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.webkit.WebView;
import android.widget.Button;

public class ResultadoBuscadorWeb extends AppCompatActivity implements View.OnClickListener {

    WebView web1;
    Button btnFinalizarActivy;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_resultado_buscador_web);

        this.web1 = this.findViewById(R.id.resultadoWebViewGoogle);
        this.btnFinalizarActivy = this.findViewById(R.id.btnFinalizarActivyResultadoBuscadorWeb);

        this.btnFinalizarActivy.setOnClickListener(this);

        Bundle bundle = getIntent().getExtras();
        String dato=bundle.getString("palabragoogle");
        this.web1.loadUrl("https://" + dato);

    }

    @Override
    public void onClick(View v) {
        this.finish();
    }
}