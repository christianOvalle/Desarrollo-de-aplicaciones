package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.NotificationCompat;
import androidx.core.app.NotificationManagerCompat;

import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.graphics.Color;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Notificaciones extends AppCompatActivity implements View.OnClickListener {

    //https://developer.android.com/guide/topics/ui/notifiers/notifications?hl=es-419


    Button btnMostrar;




    //>=8
    public static final String CANAL_ID = "NOTIFICACION";//Puede ser cualquier numero

    //Para identificar cada notificacion como unica, por si envias mas de una
    public static final int NOTIFICACION_ID = 12345;//Puede ser cualquier numero

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_notificaciones);

        this.btnMostrar = (Button) this.findViewById(R.id.btnNotificacionesMostrar);
        this.btnMostrar.setOnClickListener(this);


    }

    //Una representación de la configuración que se aplica a una colección de notificaciones con temas similares.
    public void CrearNotificacionCanal(){
        //https://developer.android.com/reference/android/app/NotificationChannel
        //validar que version del SDK tiene el dispositivo
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O){
            //api 26
            CharSequence name = "Notificacion";
            //Debemos crear un canal
            NotificationChannel  notificationChannel = new NotificationChannel(CANAL_ID,name, NotificationManager.IMPORTANCE_DEFAULT);
            //Se necesita un servicio
            NotificationManager notificationManager = (NotificationManager) this.getSystemService(Notificaciones.NOTIFICATION_SERVICE);
            //Ya ahora estamos listo para crear nuestro canal
            notificationManager.createNotificationChannel(notificationChannel);
        }
    }
    public void CrearNotificacion(){
        //this
        //this.getApplicationContext()

        //Construir la notificacion
        NotificationCompat.Builder constructorNotificacion = new NotificationCompat.Builder(this,CANAL_ID);

        constructorNotificacion.setSmallIcon(R.drawable.lobo);//Se asigna una imagen como icono
        constructorNotificacion.setContentTitle("Notificacion titulo");
        constructorNotificacion.setContentText("Notificacion text");
        constructorNotificacion.setColor(Color.BLUE);
        constructorNotificacion.setPriority(NotificationCompat.PRIORITY_DEFAULT);
        constructorNotificacion.setLights(Color.MAGENTA,1000,1000);//Luz notificacion, color,on,off
        constructorNotificacion.setVibrate(new long[] {1000,1000,1000,1000});//como sera la vibracion cada 1 segundo

        constructorNotificacion.setDefaults(Notification.DEFAULT_SOUND);//Sonido por defecto


        NotificationManagerCompat notificationManagerCompat = NotificationManagerCompat.from(this);
        notificationManagerCompat.notify(NOTIFICACION_ID,constructorNotificacion.build());
    }

    @Override
    public void onClick(View v) {
        this.CrearNotificacionCanal();//Solo se ejecuta se la api es mayor o igual 26
        this.CrearNotificacion();
    }
}