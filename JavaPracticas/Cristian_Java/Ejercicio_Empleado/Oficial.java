package com.mycompany.cristian;

public class Oficial extends Operario {

    public void tostring() {

        System.out.println("Empleado: " + GetNombre()+" -> Operario "+" -> Oficial ");

    }

    public Oficial(String nombre) {

        setNombre(nombre);
        tostring();

    }

    public Oficial() {

    }

}
