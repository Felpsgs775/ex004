using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace exercicio3
{
    class Program
    {
     static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int produto1 = A * B;
            int produto2 = C * D;
            int diferenca = produto1 - produto2;

            Console.WriteLine(diferenca);





        }  
    }
}
