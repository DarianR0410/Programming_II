// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne;
            double numberTwo;
            bool isTrue = true;

            Calculadora calculadora = new Calculadora();

            while (isTrue)
            {
                Console.WriteLine("Bienvenido a la calculadora");
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        Console.Write("Ingrese el primer número:");
                        numberOne = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número:");
                        numberTwo = Convert.ToDouble(Console.ReadLine());
                        double resultSum = calculadora.Sumar(numberOne, numberTwo);
                        Console.WriteLine($"El resultado de la suma es: {resultSum}");
                        break;
                    }

                    case 2:
                    {
                        Console.Write("Ingrese el primer número:");
                        numberOne = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número:");
                        numberTwo = Convert.ToDouble(Console.ReadLine());
                        double resultSubstraction = calculadora.Restar(numberOne, numberTwo);
                        Console.WriteLine($"El resultado de la resta es: {resultSubstraction}");
                        break;
                    }

                    case 3:
                    {
                        Console.Write("ingrese el primer numero:");
                        numberOne = Convert.ToDouble(Console.ReadLine());
                        Console.Write("ingrese el segundo numero:");
                        numberTwo = Convert.ToDouble(Console.ReadLine());
                        double restultMultiplication = calculadora.Multiplicar(numberOne, numberTwo);
                        Console.WriteLine($"El resultado de la multiplicación es: {restultMultiplication}");
                        break;
                    }

                    case 4:
                    {
                        Console.Write("ingrese el primer numero:");
                        numberOne = Convert.ToDouble(Console.ReadLine());
                        Console.Write("ingrese el segundo numero:");
                        numberTwo = Convert.ToDouble(Console.ReadLine());
                        double resultDivision = calculadora.Dividir(numberOne, numberTwo);
                        Console.WriteLine($"El resultado de la división es: {resultDivision}");
                        break;
                    }

                    case 5:
                    {
                        Console.WriteLine("Gracias por usar la calculadora");
                        isTrue = false;
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Opción no válida");
                        break;
                    }
                }

            }
        }

    }
}