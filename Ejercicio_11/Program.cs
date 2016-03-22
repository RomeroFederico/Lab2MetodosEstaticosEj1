using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11
{

    /*
    11.  Ingresar 10 números enteros que pueden estar dentro de un rango
    de entre 100 y -100.
    Para ello realizar una clase llamada 'Validacion' que posea un
    método estático llamado Validar, que posea la siguiente firma:
    bool Validar(int, int, int).
    Terminado el ingreso mostrar el valor mínimo, el valor máximo y
    el promedio.
    Nota: Utilizar variables escalares, NO utilizar vectores.
    */

    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 11";

            int numero;
            int valorMinimo = 0;
            int valorMaximo = 0;
            double promedio = 0;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write("Ingrese un numero entre el -100 y el 100: ");

                    while (!int.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.Clear();
                        Console.Write("ERROR!!! No se ha ingresado un numero. Ingrese un numero entre el -100 y el 100: ");
                    }

                    Console.Clear();
                    if (!Validacion.Validar(numero, -100, 100))
                        Console.Write("ERROR!!! Numero no valido. ");
                } while (!Validacion.Validar(numero, -100, 100));

                if (i == 0)
                {
                    valorMaximo = numero;
                    valorMinimo = numero;
                }
                else
                {
                    if (numero < valorMinimo)
                        valorMinimo = numero;
                    if (numero > valorMaximo)
                        valorMaximo = numero;
                }

                promedio += numero;
            }

            Console.Clear();
            Console.WriteLine("El valor minimo fue: {0}.\nEl valor maximo fue: {1}.\nEl promedio fue de {2,0:#,###.00}. ", valorMinimo, valorMaximo, promedio / 10);
        }
    }
}
