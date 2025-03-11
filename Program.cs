using System;
using System.Globalization;

namespace relatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horastrabalhadas = int.Parse(Console.ReadLine());
            float valorsalario = float.Parse(Console.ReadLine());
            float salario = horastrabalhadas * valorsalario;

            Console.WriteLine("NUMBER: " + numero);
            Console.WriteLine("SALARY: U$ " + salario.ToString("F2"));


        }
    }
}
