using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            Random r = new Random();

            int somaL, somaC, somaEP = 0, somaES = 0;
            bool T = true;

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = r.Next(0, 11);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Matriz:");

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    Console.Write(mat[linha, coluna] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int linha = 0;linha < mat.GetLength(0); linha++)
            {
                somaL = 0;

                for (int coluna = 0;coluna < mat.GetLength(1); coluna++)
                {

                    somaL += mat[linha, coluna];

                }
                if(linha == 0)
                {
                    somaEP = somaL;
                }
                else if(somaL != somaEP)
                {
                    T = false;
                }
            }
            for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
            {
                somaC = 0;

                for (int linha = 0; linha < mat.GetLength(0); linha++)
                {

                    somaC += mat[linha, coluna];

                }
         
                if (somaC != somaEP)
                {
                    T = false;
                }
            }

            for (int linha = 0;linha <mat.GetLength(0); linha++)
            {
               
                somaES += mat[linha, mat.GetLength(1) - 1 - linha];


            }
            if (T && somaEP == somaES)
            {
                Console.WriteLine("A matriz é um quadrado mágico");
            }
            else 
            {
                Console.WriteLine("A matriz não é um quadrado mágico");
            }
            Console.ReadLine();
        }
    }
}
