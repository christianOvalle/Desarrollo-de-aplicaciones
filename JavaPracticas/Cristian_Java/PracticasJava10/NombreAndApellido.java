import java.util.Scanner; 
class NombreAndApellido{

public static void main(String[] arg){

Scanner myObj = new Scanner(System.in);

String Nombre = myObj.nextLine();
String Apellido = myObj.nextLine();

System.out.print("Su nombre es "+Nombre+" Su apellido es "+Apellido);

}
}