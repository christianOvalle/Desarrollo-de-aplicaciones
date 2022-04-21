package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

/*
* Log.e(String, String) (error)
* Log.w(String, String) (advertencia)
* Log.i(String, String) (información)
* Log.d(String, String) (depuración)
* Log.v(String, String) (registro detallado)
*https://developer.android.com/studio/debug/am-logcat?hl=es-419
* */

public class ArchivoTxtMemoriaInterna extends AppCompatActivity implements View.OnClickListener {

    private Button btn;
    private EditText editText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_archivo_txt_memoria_interna);

        this.btn  = this.findViewById(R.id.btnArchivoTxtMemoriaInternaGuardar);
        this.editText = this.findViewById(R.id.editTextArchivoTxtMemoriaInternaArchivo);
        this.btn.setOnClickListener(this);

        this.VerArchivos();
        this.readFileTXT();
    }

    public void readFileTXT(){

        if (this.isFileExists( "notas.txt")) {
            try {
                /*
            *OpenFileOutPut
            * Abra un archivo privado asociado con el paquete de aplicación de este contexto para escribir. Crea el archivo si aún no existe.
No se requieren permisos adicionales para que la aplicación de llamada lea o escriba el archivo devuelto.
            * */

                /*
                 * InputStreamReader y OutputStreamWriter
                 * Una pareja de reader y writer que realiza un puente entre streams de bytes y streams de caracteres.
                 *
                 * InputStreamReader
                 * Un InputStreamReader lee bytes desde un InputStream y los convierte a caracteres usando la decodificación de caracteres por defecto o una decodificación de caracteres especificada por su nombre.
                 *
                 * OutputStreamWriter
                 * De forma similar, un OutputStreamWriter convierte caracteres a bytes usando una decodificación de caracteres por defecto o una decodificación de caracteres especificada por su nombre y luego escribe estos bytes en un OutputStream.
                 * */

                /*
                 * MODE_PRIVATE: es el modo por defecto con acceso privado desde nuestra aplicación.Sobreescribe el contenido del fichero.

                 * MODE_APPEND: para añadir contenido a un fichero existente.Si no existe el fichero lo crea.

                 * MODE_WORLD_READABLE: permite a otras aplicaciones leer del fichero.

                 * MODE_WORLD_WRITABLE: permite a otras aplicaciones escribir en el fichero.
                 * */
                InputStreamReader archivo = new InputStreamReader(this.openFileInput("notas.txt"));

                /*
                 * disponemos de una clase “maestra” en leer ficheros llamada BufferedReader.Una vez tenemos la instancia inicializada de BufferedReader
                 * */
                BufferedReader br = new BufferedReader(archivo);//Clase para leer el archivo

                /*
                 * readLine
                 * Lee una línea de texto. Una línea se considera terminada por cualquiera de un salto de línea ('\ n'), un retorno de carro ('\ r') o un retorno de carro seguido inmediatamente por un salto de línea.
                 * */
                String linea = br.readLine();
                String todo = "";
                while (linea != null) {
                    todo = todo + linea + "\n";
                    linea = br.readLine();
                    Log.d("ArchivosAndroid", todo);
                }
                br.close();
                archivo.close();
                this.editText.setText(todo);
            } catch (IOException e) {

            }
        }
    }
    private boolean isFileExists( String archbusca) {
        /*
         * android.content.Context Devuelve una matriz de cadenas que nombran los archivos privados asociados con el paquete de aplicación de este contexto.
         * */
        String[] archivos = this.fileList();//Archivos

        for (int f = 0; f < archivos.length; f++)
            if (archbusca.equals(archivos[f]))
                return true;
        return false;
    }

    public void saveTextOutFile() {
        try {
            /*
            *OpenFileOutPut
            * Abra un archivo privado asociado con el paquete de aplicación de este contexto para escribir. Crea el archivo si aún no existe.
No se requieren permisos adicionales para que la aplicación de llamada lea o escriba el archivo devuelto.
            * */

            /*
            * InputStreamReader y OutputStreamWriter
            * Una pareja de reader y writer que realiza un puente entre streams de bytes y streams de caracteres.
            *
            * InputStreamReader
            * Un InputStreamReader lee bytes desde un InputStream y los convierte a caracteres usando la decodificación de caracteres por defecto o una decodificación de caracteres especificada por su nombre.
            *
            * OutputStreamWriter
            * De forma similar, un OutputStreamWriter convierte caracteres a bytes usando una decodificación de caracteres por defecto o una decodificación de caracteres especificada por su nombre y luego escribe estos bytes en un OutputStream.
            * */

            /*
            * MODE_PRIVATE: es el modo por defecto con acceso privado desde nuestra aplicación.Sobreescribe el contenido del fichero.

            * MODE_APPEND: para añadir contenido a un fichero existente.Si no existe el fichero lo crea.

            * MODE_WORLD_READABLE: permite a otras aplicaciones leer del fichero.

            * MODE_WORLD_WRITABLE: permite a otras aplicaciones escribir en el fichero.
            * */
            OutputStreamWriter archivo = new OutputStreamWriter(this.openFileOutput("notas.txt", this.MODE_PRIVATE));

            //método Write() para escribir en el fichero
            archivo.write(this.editText.getText().toString());


            //archivo.flush();
            archivo.close();//Cierra el archivo
        } catch (IOException e) {
            Log.d("ArchivosAndroid",e.getMessage());
        }
        Toast t = Toast.makeText(this, "Los datos fueron grabados",Toast.LENGTH_SHORT);
        t.show();
        finish();//Finalizamos la activity
    }

    public void VerArchivos(){

        File file = this.getFilesDir();
        Log.d("ArchivosAndroid",file.getAbsolutePath());
        Log.d("ArchivosAndroid",file.getName());
        Log.d("ArchivosAndroid",file.getParent());
        Log.d("ArchivosAndroid",file.getPath());
        Log.d("ArchivosAndroid",String.valueOf(file.getUsableSpace()));
        Log.d("ArchivosAndroid",String.valueOf(file.getFreeSpace()));
        String[] archivos = this.fileList();
        Log.d("ArchivosAndroid",String.valueOf(archivos.length));
        for (String archivo : archivos ) {
            Log.d("ArchivosAndroid", archivo);
            Toast.makeText(this, "Archivo "+archivo, Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    public void onClick(View v) {
        this.saveTextOutFile();
    }
}
