package com.mycompany.cristian;

/**
 *
 * @author Infotep
 */
public class Empleados {

    private String nombre;

    //Metodo para asignar nombre a empleado
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    //Metodo que retorna el nombre del empleado obtenido en el metodo anterior
    public String GetNombre() {

        return this.nombre;
    }

    //Metodo Que indiica la posicion del empleado
    public void tostring() {

        System.out.println("Empleado: " + this.nombre);
    }

    public Empleados() {

    }

    public Empleados(String nombre) {
        this.nombre = nombre;
        tostring();
    }
}
