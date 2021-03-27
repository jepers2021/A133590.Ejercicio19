using System;

namespace A133590.Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 19");
            Console.WriteLine("Dado un número, presenta su parte entera.");
            Console.Write("Por favor, ingrese un número: ");
            double numero;
            bool exito = Double.TryParse(Console.ReadLine(), out numero);
            if (!exito)
            {
                Console.WriteLine("Ingreso inválido, no puede ser interpretado como numérico.");
                return;
            }

            Console.WriteLine($"Parte entera del número: {Math.Floor(numero)}");
        }
    }
}
