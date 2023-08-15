using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_complementario_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int estudiantes;
            
            Console.WriteLine("\t Sumatoria de pesos de los estudiantes de Laboratorio de Programación Orientada a Objetos");

            // consultar total de estudiantes
            Console.Write("\n\t Favor digitar el total de estudiantes del Laboratorio: ");
            estudiantes = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            // crear un array de tipo double para almacenar el peso de los estudiantes con dimension del total de estudiantes
            double[] pesos = new double[estudiantes];

            for (int i = 0; i < estudiantes; i++)
            {
                // almacenar en el array de los pesos segun la cantidad de estudiantes previamente digitados
                Console.Write($"\t Digitar el peso en kg del estudiante {i+1}: ");
                pesos[i] = double.Parse(Console.ReadLine());
            }

            double Suma = 0.0;

            foreach (double peso in pesos)
            {
                // para cada peso en el array peso se suma al anterior
                Suma += peso;
            }

            Console.WriteLine($"\n\t El resultado de la suma es : {Suma} kg");

            Console.ReadKey();
        }
    }
}
