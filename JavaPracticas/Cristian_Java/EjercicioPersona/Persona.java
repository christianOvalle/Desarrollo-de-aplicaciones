package  EjercicioPersona;

public class Persona {

    private String nombre, domicilio, horario;

    //Nombre
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getNombre() {
        return this.nombre;
    }

    //Domicilio
    public void setDomicilio(String domicilio) {
        this.domicilio = domicilio;
    }

    public String getDomicilio() {
        return this.domicilio;
    }

    //Horario
    public void setHorario(String horario) {
        this.horario = horario;
    }

    public String getHorario() {
        return this.horario;
    }

    public void asistir() {
        System.out.println("Persona{");
        System.out.println("Nombre: " + this.nombre);
        System.out.println("Domicilio: " + this.domicilio);
        System.out.println("Horario: " + this.horario);
        System.out.println("Asistiendo...");
        System.out.println("}");
    }

    public Persona() {
    }

    public Persona(String nombre, String domicilio, String horario) {
        this.nombre = nombre;
        this.domicilio = domicilio;
        this.horario = horario;
        asistir();
    }
}
