package com.example.myapplication;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

public class MenuContextualExample extends AppCompatActivity {

    TextView t1;
    LinearLayout layoutPadre;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_contextual_example);

        this.t1 = (TextView) this.findViewById(R.id.textView12);
        this.layoutPadre =(LinearLayout) this.findViewById(R.id.linerLayoutMenuContextualExamplePadre);

        //Registramos el context menu para el view
        registerForContextMenu(this.t1);
    }
    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        menu.setHeaderTitle("Elija el color de fondo:");
        MenuInflater inflater = this.getMenuInflater();
        inflater.inflate(R.menu.menu1, menu);
    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
       // String viewIDString = String.valueOf(item.getItemId());
       // Toast.makeText(this, "ejemplo text toast "+viewIDString, Toast.LENGTH_SHORT).show();


        int color = android.graphics.Color.rgb(255,255,255);
        switch (item.getItemId()){
            case R.id.item1:
                color = android.graphics.Color.rgb(255,0,0);
                break;
            case R.id.item2:
                color = android.graphics.Color.rgb(0   ,255,0);
                break;
            case R.id.item3:
                color = android.graphics.Color.rgb(0,0,255);
                break;
        }
        this.layoutPadre.setBackgroundColor(color);
        return true;
    }

}