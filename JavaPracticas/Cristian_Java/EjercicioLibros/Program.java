/*
 * Click nbfs://nbhost/SystemFileSynstem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package EjercicioLibros;

import java.util.Scanner;

/**
 *
 * @author Infotep2019
 */
public class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Publicacion pub = new Publicacion();
        Cd cd = new Cd();
        Libro lib = new Libro();
        System.out.println("REGISTRO DE LIBROS \n");
        System.out.println("Ingrese titulo del libro \n");
        pub.setTitulo(sc.nextLine());
        System.out.println(" ");
        System.out.println("Ingrese Precio del libro \n");
        pub.setPrecio(sc.nextDouble());
        System.out.println(" ");
        System.out.println("Ingrese Cantidad de paginas del libro \n");
        lib.setNumeroDePaginas(sc.nextInt());
        System.out.println(" ");
        System.out.println("Ingrese Tiempo en minutos del cd del libro \n");
        cd.setTimePlay(sc.nextDouble());
        System.out.println(" ");

        pub.MostrarDatos();
        lib.MostraPaginas();
        cd.MostrarTiempo();
    }

}
