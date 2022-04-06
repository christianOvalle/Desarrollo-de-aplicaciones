package ejercicio2;

public class Empleado extends Persona {

    private String jefe;

    public void cobrar() {
        System.out.println("Empleado{");
        System.out.println("Nombre: " + getNombre());
        System.out.println("Domicilio: " + getDomicilio());
        System.out.println("Horario: " + getHorario());
        System.out.println("Jefe: " + this.jefe);
        System.out.println("Cobrando...");
        System.out.println("}");
    }

    public Empleado() {}

    public Empleado(String nombre, String domicilio, String horario, String jefe) {
        setNombre(nombre);
        setDomicilio(domicilio);
        setHorario(horario);
        this.jefe = jefe;
        cobrar();
    }
}
