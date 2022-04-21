package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

public class PrincipalActivityMenuListView extends AppCompatActivity implements AdapterView.OnItemClickListener {

    ListView listViewActivities;
    String[] activitysNames = {
                                "UNIDAD I",
	                            "Unidad 1 Breve historia android-IntroduccionAndroid",
                                "Unidad 1 SDK-SDKTeoria",
	                            "Unidad 1 Instalación del Android Studio-InstalacionAndroid",
                                "Unidad 1 Listas-ListaTeoria",
	                            "Unidad 1 Pilas-PilaTeoria",
	                            "Unidad 1 Colas-ColaTeoria",
                                "UNIDAD II",
                                "Unidad 2 Clase abstracta-ClaseAbstractaTeoria",
                                "Unidad 2 Clase interface-ClaseInterfaceTeoria",
                                "Unidad 2 Diferencia clase abstracta e interface-DiferenciaClaseAbstractaInterfaceTeoria",
                                "Unidad 2 Herencias múltiples en java-HerenciaMultipleJavaTeoria",
                                "UNIDAD III",
                                "Unidad 3 Botones,Componentes Basicos-MainActivity",
                                "Unidad 3 RadioGroup, RadioButton -CalculadoraRadioButon",
                                "Unidad 3 Checkbox-CheckBoxExample",
                                "Unidad 3 Control Spinner-CalculadoraSpinner",
                                "Unidad 3 ListView-ListViewExample",
                                "Unidad 3 ImageButton-ImageButtonExample",
                                "Unidad 3 Lanzamiento un Segundo Activity y pasar parámetros-BuscadorWeb",
                                "UNIDAD IV",
                                "Unidad 4 SharedPreferences-XMLSheredPreferencesExample",
                                "Unidad 4 Almacenamiento de datos en un archivo de texto en la memoria interna-ArchivoTxtMemoriaInterna",
                                "Unidad 4 Almacenamiento de datos en un archivo de texto en la memoria SD-ArchivoTxtMemoriaExterna",
                                "Unidad 4 Almacenamiento en una base de datos SQLite-CRUDSqlite",
                                "UNIDAD V",
                                "Unidad 5 Concepto de Layout-ConceptoLayout",
                                "Unidad 5 Linea Layout-LinearLayoutExample",
                                "Unidad 5 TableLayout-TableLayoutExample",
                                "Unidad 5 RelativeLayout-RelativeLayoutExample",
                                "Unidad 5 FrameLayout-FrameLayoutExample",
                                "Unidad 5 ScrollView y LinearLayout-ScrollViewLinearLayoutExample",
                                "Unidad 5 Iconos de la aplicación-CambiarIconoApp",
                                "UNIDAD VI",
                                "Unidad 6 Reproducción de audio-MediaPlayerReproducirAudioExample",//Reproducir audio, memoria interna
                                "Unidad 6 Reproducción, pausa, continuación y detención de un archivo de audio-ControlReproductor",//Control audio
                                "Unidad 6 Reproducción de archivo desde una tarjeta SD-ReproducirAudioMemoriaExterna",//Reproducir audio memoria externa
                                "Unidad 6 Reproducción de archivo desde internet-ReproductorAudioMP3DesdeInternet",//Reproducir audio desde internet
                                "Unidad 6 Reproducción de archivo de audio desde el reproductor de android via INTENT-ReproductorAndroid",
                                "Unidad 6 Captura y grabación de audio desde INTENT-GrabarAudioConLaGrabadoraAndroid",
                                "Unidad 6 Captura y grabación de audio mediante la clase MediaRecorder-GrabadoraPersonalMediaRecorder",
                                "UNIDAD VII",
                                "Unidad 7 Menú de opciones-MenuOpciones",
                                "Unidad 7 Menú de opciones con submenú-MenuOpcionesSubMenu",
                                "Unidad 7 Menú de opciones con iconos en los menuItem-MenuOpcionesIcono",
                                "Unidad 7 Menú contextual-MenuContextualExample",
                                "Unidad 7 Concepto de notificaciones teoria-ConceptoNotificacion",
                                "Unidad 7 Concepto de notificaciones ejemplo-Notificaciones",
                                "Unidad 7 AlertDialog Simple-AlertDialogSimple",
                                "Unidad 7 AlertDialog con botones-AlertDialogBotones",
                                "Unidad 7 Notificaciones mediante clase Toast-ToastExample",
                                "Unidad 7 Evento Touch-TouchEventExample",
                                "Unidad 7 Archivos String.xml teoria-StringArchivoLeguaje",
                                "Unidad 7 Archivos String.xml ejemplo-StringFrutasVariosIdiomas",
                                "-EnviarMensajeWhatsappSinGuardarNumero"
                            };


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_principal_menu_list_view);

        this.listViewActivities = (ListView) this.findViewById(R.id.listViewMenuActivity);
        this.listViewActivities.setOnItemClickListener(this);

        this.LlenarListView();
    }

    public void LlenarListView(){
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1,this.activitysNames);
        this.listViewActivities.setAdapter(adapter);


        //Código para la condición de los permisos dentro del método OnCreate:
        if (ContextCompat.checkSelfPermission(getApplicationContext(), Manifest.permission.WRITE_EXTERNAL_STORAGE) != PackageManager.PERMISSION_GRANTED && ActivityCompat.checkSelfPermission(getApplicationContext(), Manifest.permission.RECORD_AUDIO) != PackageManager.PERMISSION_GRANTED) {
            ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.WRITE_EXTERNAL_STORAGE, Manifest.permission.RECORD_AUDIO}, 1000);
        }

    }

    @Override
    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

            String actividadSeleccionada = this.listViewActivities.getItemAtPosition(position).toString();
            if (actividadSeleccionada.contains("-"))
                actividadSeleccionada = actividadSeleccionada.split("-")[1];

            switch (actividadSeleccionada){
                case "MainActivity":
                    Intent intent = new Intent(this,MainActivity.class);
                    this.startActivity(intent);
                    break;
                case "BuscadorWeb":
                    Intent intent1 = new Intent(this,BuscadorWeb.class);
                    this.startActivity(intent1);
                    break;
                case "XMLSheredPreferencesExample":
                    Intent intent2 = new Intent(this,XMLSheredPreferencesExample.class);
                    this.startActivity(intent2);
                    break;
                case "CRUDSqlite":
                    Intent intent3 = new Intent(this,CRUDSqlite.class);
                    this.startActivity(intent3);
                    break;
                case "LinearLayoutExample":
                    Intent intent4 = new Intent(this,LinearLayoutExample.class);
                    this.startActivity(intent4);
                    break;
                case "ScrollViewLinearLayoutExample":
                    Intent intent5 = new Intent(this,ScrollViewLinearLayoutExample.class);
                    this.startActivity(intent5);
                    break;

                case "RelativeLayoutExample":
                    Intent intent6 = new Intent(this,RelativeLayoutExample.class);
                    this.startActivity(intent6);
                    break;
                    //
                case "FrameLayoutExample":
                    Intent intent7 = new Intent(this,FrameLayoutExample.class);
                    this.startActivity(intent7);
                    break;
                //
                case "MediaPlayerReproducirAudioExample":
                    Intent intent8 = new Intent(this,MediaPlayerReproducirAudioExample.class);
                    this.startActivity(intent8);
                    break;

                //
                case "ControlReproductor":
                    Intent intent9 = new Intent(this,ControlReproductor.class);
                    this.startActivity(intent9);
                    break;
                //ReproductorAudioMP3

                case "ReproductorAudioMP3DesdeInternet":
                    Intent intent10 = new Intent(this,ReproductorAudioMP3.class);
                    this.startActivity(intent10);
                    break;
                case "ListViewExample":
                    Intent intent11 = new Intent(this,ListViewExample.class);
                    this.startActivity(intent11);
                    break;
                    //ReproductorAndroid

                case "ReproductorAndroid":
                    Intent intent13 = new Intent(this,ReproductorAndroid.class);
                    this.startActivity(intent13);
                    break;
                case "ArchivoTxtMemoriaInterna":
                    Intent intent12 = new Intent(this,ArchivoTxtMemoriaInterna.class);
                    this.startActivity(intent12);
                    break;
                case "ArchivoTxtMemoriaExterna":
                    Intent intent14 = new Intent(this,ArchivoTxtMemoriaExterna.class);
                    this.startActivity(intent14);
                    break;


                case "ReproducirAudioMemoriaExterna":
                    Intent intent15 = new Intent(this,ReproducirAudioMemoriaExterna.class);
                    this.startActivity(intent15);
                    break;

                case "GrabarAudioConLaGrabadoraAndroid":
                    Intent intent16 = new Intent(this,GrabarAudioConLaGrabadoraAndroid.class);
                    this.startActivity(intent16);
                    break;

                case "GrabadoraPersonalMediaRecorder":
                    Intent intent17 = new Intent(this,GrabadoraPersonalMediaRecorder.class);
                    this.startActivity(intent17);
                    break;

                case "MenuOpciones":
                    Intent intent18 = new Intent(this,MenuOpciones.class);
                    this.startActivity(intent18);
                    break;

                case "MenuOpcionesSubMenu":
                    Intent intent19 = new Intent(this,MenuOpcionesSubMenu.class);
                    this.startActivity(intent19);
                    break;

                case "MenuOpcionesIcono":
                    Intent intent20 = new Intent(this,MenuOpcionesIcono.class);
                    this.startActivity(intent20);
                    break;

                case "TableLayoutExample":
                    Intent intent21 = new Intent(this,TableLayoutExample.class);
                    this.startActivity(intent21);
                    break;

                case "Notificaciones":
                    Intent intent22 = new Intent(this,Notificaciones.class);
                    this.startActivity(intent22);
                    break;

                case "AlertDialogSimple":
                    Intent intent23 = new Intent(this,AlertDialogSimple.class);
                    this.startActivity(intent23);
                    break;


                case "AlertDialogBotones":
                    Intent intent24 = new Intent(this,AlertDialogBotones.class);
                    this.startActivity(intent24);
                    break;
                case "ToastExample":
                    Intent intent25 = new Intent(this,ToastExample.class);
                    this.startActivity(intent25);
                    break;
                case "TouchEventExample":
                    Intent intent26 = new Intent(this,TouchEventExample.class);
                    this.startActivity(intent26);
                    break;
                case "StringFrutasVariosIdiomas":
                    Intent intent27 = new Intent(this,StringFrutasVariosIdiomas.class);
                    this.startActivity(intent27);
                    break;
                case "CalculadoraRadioButon":
                    Intent intent28 = new Intent(this,CalculadoraRadioButon.class);
                    this.startActivity(intent28);
                    break;
                case "CalculadoraSpinner":
                    Intent intent29 = new Intent(this,CalculadoraSpinner.class);
                    this.startActivity(intent29);
                    break;
                case "ImageButtonExample":
                    Intent intent30 = new Intent(this,ImageButtonExample.class);
                    this.startActivity(intent30);
                    break;
                case "MenuContextualExample":
                    Intent intent31 = new Intent(this,MenuContextualExample.class);
                    this.startActivity(intent31);
                    break;
                case "EnviarMensajeWhatsappSinGuardarNumero":
                    Intent intent32 = new Intent(this,EnviarMensajeWhatsappSinGuardarNumero.class);
                    this.startActivity(intent32);
                    break;



            /*
                En construccion
            */


                case "IntroduccionAndroid":
                    Toast.makeText(this, "En contruccion Unidad 1 Breve historia android-IntroduccionAndroid", Toast.LENGTH_LONG).show();
                    break;
                case "SDKTeoria":
                    Toast.makeText(this, "En contruccion Unidad 1 SDK-SDKTeoria", Toast.LENGTH_LONG).show();
                    break;
                case "InstalacionAndroid":
                    Toast.makeText(this, "En contruccion Unidad 1 Instalación del Android Studio-InstalacionAndroid", Toast.LENGTH_LONG).show();
                    break;
                case "ListaTeoria":
                    Toast.makeText(this, "En contruccion Unidad 1 Listas-ListaTeoria", Toast.LENGTH_LONG).show();
                    break;
                case "PilaTeoria":
                    Toast.makeText(this, "En contruccion Unidad 1 Pilas-PilaTeoria", Toast.LENGTH_LONG).show();
                    break;
                case "ColaTeoria":
                    Toast.makeText(this, "En contruccion Unidad 1 Colas-ColaTeoria", Toast.LENGTH_LONG).show();
                    break;
                case "ClaseAbstractaTeoria":
                    Toast.makeText(this, "En contruccion Unidad 2 Clase abstracta-ClaseAbstractaTeoria", Toast.LENGTH_LONG).show();
                    break;

                case "ClaseInterfaceTeoria":
                    Toast.makeText(this, "En contruccion Unidad 2 Clase interface-ClaseInterfaceTeoria", Toast.LENGTH_LONG).show();
                    break;

                case "DiferenciaClaseAbstractaInterfaceTeoria":
                    Toast.makeText(this, "En contruccion Unidad 2 Diferencia clase abstracta e interface-DiferenciaClaseAbstractaInterfaceTeoria", Toast.LENGTH_LONG).show();
                    break;
                case "HerenciaMultipleJavaTeoria":
                    Toast.makeText(this, "En contruccion Unidad 2 Herencias múltiples en java-HerenciaMultipleJavaTeoria", Toast.LENGTH_LONG).show();
                    break;
                case "StringArchivoLeguaje":
                    Toast.makeText(this, "En contruccion Unidad 7 Archivos String.xml teoria-StringArchivoLeguaje", Toast.LENGTH_LONG).show();
                    break;
                case "ConceptoNotificacion":
                    Toast.makeText(this, "En contruccion Unidad 7 Concepto de notificaciones teoria-ConceptoNotificacion", Toast.LENGTH_LONG).show();
                    break;
                case "CambiarIconoApp":
                    Toast.makeText(this, "En contruccion Unidad 5 Iconos de la aplicación-CambiarIconoApp", Toast.LENGTH_LONG).show();
                    break;
                default:
                    Toast.makeText(this, "No es una opcion", Toast.LENGTH_SHORT).show();
                    break;
            }
    }
}