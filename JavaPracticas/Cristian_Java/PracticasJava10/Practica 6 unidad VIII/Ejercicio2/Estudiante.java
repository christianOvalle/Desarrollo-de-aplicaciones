package ejercicio2;

public class Estudiante extends Persona {

    private int grado;
    private char grupo;

    public void estudiar() {

        System.out.println("Estudiante{");
        System.out.println("Nombre: " + getNombre());
        System.out.println("Domicilio: " + getDomicilio());
        System.out.println("Horario: " + getHorario());
        System.out.println("Grado: " + this.grado);  
        System.out.println("Grupo: " + this.grupo);
        System.out.println("Estudiando...");
        System.out.println("}");

    }

    public Estudiante(String nombre, String domicilio, String horario, int grado, char grupo) {

        setNombre(nombre);
        setDomicilio(domicilio);
        setHorario(horario);
        this.grado = grado;
        this.grupo = grupo;

        estudiar();

    }

}
