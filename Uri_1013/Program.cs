using System;

namespace Uri_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);

            int MAIORAB = (A + B + Math.Abs(A - B))/2;

            int MAIOR = (MAIORAB + C + Math.Abs(MAIORAB - C)) / 2;

            Console.WriteLine($"{MAIOR} eh o maior");
                        
        }
    }
}
