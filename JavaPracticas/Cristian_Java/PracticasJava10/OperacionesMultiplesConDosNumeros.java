import java.util.Scanner;

class OperacionesMultiplesConDosNumeros{

public static void main(String[] arg){

Scanner Obj = new Scanner(System.in);



System.out.print("Ingrese Primera Cantidad ");		
int Numero1 = Obj.nextInt();
System.out.print("Ingrese Segunda Cantidad ");	
int Numero2 = Obj.nextInt();


System.out.println("1.Suma");
System.out.println("2.Resta");
System.out.println("3.Multiplicacion");
System.out.println("4.Division");
System.out.println("5.Resto");
System.out.println("6.Potenciacion");
System.out.println("7.Raiz Cuadrada");

System.out.print("Que desea Realizar?");
int opcion = Obj.nextInt();

switch(opcion){

case 1:
    System.out.print("La suma es igual a "+(Numero1+Numero2));   
	break;	
case 2:
    System.out.print("La Resta es igual a "+(Numero1-Numero2));   
	break;	
case 3:
    System.out.print("La Multiplicacion es igual a "+(Numero1*Numero2));   
	break;	






}

}
}