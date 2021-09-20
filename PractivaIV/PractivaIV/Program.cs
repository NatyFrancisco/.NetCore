using System;
using System.Collections.Generic;

namespace PractivaIV
{

    delegate double itbis(int x, double y);

    public class Program
    {


        public static void Main(string[] args)
        {
            // En un proyecto de consola:
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("1 - Hacer un método extendido que opere sobre el tipo List<int> llamado Pares() " +
                "que retorne un List<int> con los valores pares en la lista asociada dada. En la implementación " +
                "del método Pares() utilice el método  FindAll() de las listas para pasarle una función predicado " +
                "mediante la implementación de un delegado que represente métodos que retornen bool y que reciban un" +
                " entero como parámetro.");

            //Lista para los metodos de numeros pares e imapres
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12 };

            Console.WriteLine("\n***********************************************");
            Console.WriteLine("Los numeros pares de la lista son: ");

            //Metodo Pares() con el metodo FindAll y el delegado
            var Pares = lista.FindAll(delegate (int x)
          {
              if (x % 2 == 0)
              {
                  Console.WriteLine(x);
                  x++;
              }
              return true;

          });

            Console.WriteLine("\n---------------------------------------------------------------");
            Console.WriteLine("2 - Escriba los siguiente método como expresión lambda:");

            Console.WriteLine("\nLos numeros impares de la lista son: ");
            //Hacemos la condicion de los numeros impares
            List<int> EsImpar = lista.FindAll(x => x % 2 != 0);
            //Recorre la lista
            foreach (int x in EsImpar)
                Console.WriteLine(x);
        


            Console.WriteLine("\n***********************************************");
            Console.WriteLine("Metodo lambda del ITBIS");           
            double calculoDeITBIS = CalcularITBIS(precio: 100);
            Console.WriteLine("El itbis es: " + calculoDeITBIS);

            // Espera

            Console.WriteLine("\n***********************************************");
            Console.WriteLine("Metodo lambda de la fecha");


            var fecha = DateTime.Now;
            Console.WriteLine("La fecha es:" + fecha);
        }

        public static double CalcularITBIS(double precio) 
        {
            //Not null
            double itbis = ((precio * 18) / 100 > 0) ? (precio * 18) / 100 : 0; 
            return itbis;
        }

    }
}
