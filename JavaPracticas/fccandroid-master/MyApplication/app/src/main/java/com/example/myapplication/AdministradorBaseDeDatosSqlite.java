package com.example.myapplication;


import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

//SQLiteOpenHelper
public class AdministradorBaseDeDatosSqlite extends SQLiteOpenHelper {

//https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper

    public AdministradorBaseDeDatosSqlite(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        /*
        Context: para utilizar para localizar rutas a la base de datos. Este valor puede ser null.
        *
        String: del archivo de base de datos, o nulo para una base de datos en memoria. Este valor puede ser null.
        *
        SQLiteDatabase.CursorFactory: para usar para crear objetos de cursor, o nulo para el valor predeterminado. Este valor puede ser null.
        *
        int: número de la base de datos (a partir de 1); si la base de datos es más antigua, se utilizará para actualizar la base de datos; si la base de datos es más nueva, se utilizará para degradar la base de datosonUpgrade(SQLiteDatabase, int, int)onDowngrade(SQLiteDatabase, int, int)
        * */
        super(context, name, factory, version);
    }

    public AdministradorBaseDeDatosSqlite(@Nullable Context context) {
        /*
        Context: para utilizar para localizar rutas a la base de datos. Este valor puede ser null.
        *
        String: del archivo de base de datos, o nulo para una base de datos en memoria. Este valor puede ser null.
        *
        SQLiteDatabase.CursorFactory: para usar para crear objetos de cursor, o nulo para el valor predeterminado. Este valor puede ser null.
        *
        int: número de la base de datos (a partir de 1); si la base de datos es más antigua, se utilizará para actualizar la base de datos; si la base de datos es más nueva, se utilizará para degradar la base de datosonUpgrade(SQLiteDatabase, int, int)onDowngrade(SQLiteDatabase, int, int)
        * */
        super(context, "DBEmpresa", null, 1);
    }
    /*
     * El método onCreate se le llama cuando la base de datos se crea por primera vez.
     * Aquí es donde se define la estructura de las tablas y se cargan eventualmente los datos iniciales
     * */
    @Override
    public void onCreate(SQLiteDatabase db) {
        //AUTOINCREMENT se coloca despues del primery key
        db.execSQL(
                "create table personas(id integer primary key AUTOINCREMENT, cedula text, nombre text)"
        );

    }


    /*
     * En el método onUpgrade se llama cuando la base de datos debe ser actualizada.
     * Tiene por objetivo eliminar tablas, añadir tablas, o hacer cualquier otra cosa que necesita para actualizarse.
     *
     *  */
    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("drop table if exists personas");
        db.execSQL(
                "create table personas(id integer primary key AUTOINCREMENT, cedula text, nombre text)"
        );

    }



}
