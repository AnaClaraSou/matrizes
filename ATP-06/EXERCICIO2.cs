using System;

namespace EXERCICIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            bool T = true;
            Random r = new Random();

            Console.WriteLine("Informe o valor de n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de m: ");
            m = int.Parse(Console.ReadLine());

            int[,] mat1 = new int[n, m];
            int[,] mat2 = new int[n, m];

            for (int linha = 0; linha < mat1.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat1.GetLength(1); coluna++)
                {
                    mat1[linha, coluna] = r.Next(0, 11);
                    Console.Write(mat1[linha, coluna] + " ");


                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int linha = 0; linha < mat2.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat2.GetLength(1); coluna++)
                {
                    mat2[linha, coluna] = r.Next(0, 11);
                    Console.Write(mat2[linha, coluna] + " ");

                }
                Console.WriteLine();
            }
            for (int linha = 0; linha < mat1.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat1.GetLength(1); coluna++)
                {

                    if (mat1[linha, coluna] != mat2[linha, coluna])
                    {

                        T = false;
                    }

                }
            }
            if (T)
            {
                Console.WriteLine("\nAs matrizes são iguais");
            }
            else
            {
                Console.WriteLine("\nAs matrizes não são iguais");
            }
            Console.ReadLine();
        }
    }
}
