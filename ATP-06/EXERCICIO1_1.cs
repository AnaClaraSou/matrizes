using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int somaL, somaC, somaD = 0, somaS = 0, n;
            Random r = new Random();
            Console.WriteLine("Informe o valor de n");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                somaL = 0;
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = r.Next(0, 11);
                    somaL += mat[linha, coluna];
                    Console.Write(mat[linha, coluna] + " ");
                }
                Console.WriteLine($"A soma da linha é: {somaL}");
                Console.WriteLine();
            }


            for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
            {
                somaC = 0;
                for (int linha = 0; linha < mat.GetLength(0); linha++)
                {
                    mat[linha, coluna] = r.Next(0, 11);
                    somaC += mat[linha, coluna];
                    Console.Write(mat[linha, coluna] + " ");
                }
                Console.WriteLine($"A soma da coluna é: {somaC}");
                Console.WriteLine();
            }


            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {

                mat[linha, linha] = r.Next(0, 11);
                somaD += mat[linha, linha];
                Console.Write(mat[linha, linha] + " ");

            }
            Console.WriteLine();
            Console.WriteLine($"A soma da diagonal principal é: {somaD}");

            for (int linha = 0, coluna = mat.GetLength(1) - 1; linha < mat.GetLength(0); linha++, coluna--)
            {

                mat[linha, coluna] = r.Next(0, 11);
                somaS += mat[linha, coluna];
                Console.Write(mat[linha, coluna] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"A soma da diagonal secundária é: {somaS}");
            Console.ReadLine();
        }
    }
}
