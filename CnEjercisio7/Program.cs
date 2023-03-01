using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnEjercisio7
{
    internal class Program
    {
        /// <summary>
        ///nombre:Juan Esteban Ortiz Rendon
        ///Fecha:28/08/2023
        ///Descripcion:Algoritmo que permita inscribir 3 numeros por teclado imprima el valor de mayor valor y el de menor valor
        ///</summary>

        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor escriba el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Porfavor escriba el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Porfavor escriba el tercer numero");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El numero mayor es:" + NumeroMayor(num1, num2, num3));
            Console.WriteLine("El numero menor es:" + NumeroMenor(num1, num2, num3));
            Console.ReadLine();

        }

        static double NumeroMayor(double num1, double num2, double num3)
        {
            if (num1 > num2 & num1 > num2)
            {
                return num1;
            }
            else if (num2 > num1 & num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }

        }
        static double NumeroMenor(double num1, double num2, double num3)
        {
            if (num1 < num2 & num1 < num2)
            {
                return num1;
            }
            else if (num2 < num1 & num2 < num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }

        }
    }
}