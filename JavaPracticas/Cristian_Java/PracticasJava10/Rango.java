import java.util.Scanner;

class Rango{

public static void main (String[] arg){

Scanner myObj = new Scanner(System.in);

int Numero = myObj.nextInt();

if(Numero < 500 || Numero > 700){

System.out.print("No Esta en el rango");

}

else{

System.out.print(Numero);

}

}
}