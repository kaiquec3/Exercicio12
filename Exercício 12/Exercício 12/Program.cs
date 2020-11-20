using System;

namespace Exercício_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Triangulo();
            double k;

            do
            {
                Console.Write("Informe o primeiro lado do triângulo: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetLado1(k);
            }
            while (k <= 0);

            do
            {
                Console.Write("Informe o segundo lado do triângulo: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetLado2(k);
            }
            while (k <= 0);

            do
            {
                Console.Write("Informe o terceiro lado do triângulo: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetLado3(k);
            }
            while (k <= 0);

            if (a1.VerificarSeETriangulo() == 1)
            {
                Console.WriteLine($"Estes lados formam um triângulo {a1.DeterminarTipoDeTriangulo()}");
            }
            else Console.WriteLine(a1.DeterminarTipoDeTriangulo());

        }
    }
}
