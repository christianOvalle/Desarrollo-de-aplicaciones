package EjercicioPersona;
import java.util.Scanner;

public class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Persona person = new Persona("Cirilo", "Gualey", "8:00 - 2:00");
        System.out.println(" ");
        Empleado empl = new Empleado("Luis", "Pantoja", "6:00 - 9:00", "Gregorio");
        System.out.println(" ");
        Estudiante est = new Estudiante("Albert","Guachupita","8:00 - 4:00",4,'A');
        System.out.println(" Esta llenando los datos del administrador");
        Administrador adm = new Administrador(sc.nextLine(), sc.nextLine(), sc.nextLine(),sc.nextLine());
        System.out.println(" ");
        Profesor profe = new Profesor("Julian","Tavarez","2:00 - 8:00","Matematicas");
        
    }

}
