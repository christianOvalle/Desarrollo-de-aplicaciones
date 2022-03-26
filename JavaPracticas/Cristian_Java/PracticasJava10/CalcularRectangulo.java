import java.util.Scanner;

class CalcularRectangulo{


public static void main(String[] arg){

Scanner Obj = new Scanner(System.in);


System.out.print("Ingrese la base de la figura ");
int Base = Obj.nextInt();
System.out.print("Ingrese la Altura de la figura ");
int Altura = Obj.nextInt();

System.out.print("El area de su figura es "+Base*Altura);




}
}