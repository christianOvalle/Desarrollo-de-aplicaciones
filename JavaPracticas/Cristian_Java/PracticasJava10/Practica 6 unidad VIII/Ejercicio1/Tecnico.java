/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.cristian;

/**
 *
 * @author Infotep
 */
public class Tecnico extends Oficial {

    public void tostring() {

        System.out.println("Empleado: " + GetNombre()+" -> Operario "+" -> Tecnico ");

    }

    public Tecnico(String nombre) {

        setNombre(nombre);
        tostring();

    }

}
