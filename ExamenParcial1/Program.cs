﻿using System;

namespace ExamenParcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables problema 1.
            int a;
            int b;
            int c;

            //Problema 1.
            //Ingresar los valores y asignarlos a sus variables.
            Console.WriteLine("----------------------------------PROBLEMA 1----------------------------------");
            Console.WriteLine("Ingrese el valor del numero 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 2");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 3");
            c = int.Parse(Console.ReadLine());

            //Este if-else combrobará sí los números son pitagóricos de acuerdo a la fórmula c2 = a2+b2
            //Dependiendo del resultado, imprimirá la elección.
            if ((c * c) == (a * a) + (b * b))
            {
                Console.WriteLine("Los números: "+a+ " " + b + " " + c + " Son un trio pitagórico");
            }
            else
            {
                Console.WriteLine("Los números: "+a+ " " + b + " " + c + " NO son un pitagóricos");
            }

            //Problema 2.
            //Varaibles problema 2.
            int tope = 10;
            int[] numeros= new int[tope];
            int dato;
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------PROBLEMA 2----------------------------------");
            //Ciclo for para rellenar el arreglo con los 10 datos.
            for (int i = 0; i < tope; i++)
            {
                Console.WriteLine("Ingrese el número " + (i + 1));
                dato = int.Parse(Console.ReadLine());
                numeros.SetValue(dato, i);

                //if-else para determinar qué tipo de valor es y aumentar su contador correspondiente.
                if(dato > 0)//Sí es positivo.
                {
                    positivos++;
                }
                else if (dato < 0) //sí es negativo
                {
                    negativos++;
                }
                else if (dato == 0) //sí es un valor 0
                {
                    ceros++;
                }
            }
            //Imprimir los datos.
            Console.WriteLine("Total de números positivos: " + positivos);
            Console.WriteLine("Total de números negativos: " + negativos);
            Console.WriteLine("Total de ceros en el arreglo: " + ceros);


            //Problema 3.
            //Variables problema 3.
            double h; //valor de la casa.
            double interes; //valor de la tasa de interés.
            double n; //valor de los años.
            double m; //valor cuota respectiva.
            double r;//variable a usar
            //fórmula --> m = (h * r) / (1-(1-r)^(-12*n))   r --> interes / (100 *12)

            //ingresar los valores.
            Console.WriteLine("");
            Console.WriteLine("----------------------------------PROBLEMA 2----------------------------------");
            Console.WriteLine("Ingrese el valor de la casa: ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la tasa de interés: ");
            interes = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de años: ");
            n = double.Parse(Console.ReadLine());

            //cálculo de "r"
            r = interes / (100*12);
            //cálculo de m;
            m = (h * r) / (1-(Math.Pow((1 - r), (-12 * n))));
            //imprimir valor de m.
            Console.WriteLine("La cuota respectiva a pagar es: $" + m );



            Console.ReadLine();
        }
    }
}
