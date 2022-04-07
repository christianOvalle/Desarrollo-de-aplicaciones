/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EjercicioEmpleado;

/**
 *
 * @author Infotep
 */
public class Directivo extends Empleados {

    public void tostring() {

        System.out.println("Empleado: " + GetNombre()+" -> Directivo");

    }

    public Directivo(String nombre) {

        setNombre(nombre);
        tostring();

    }

}
