using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[4, 4];
            Random r = new Random();
            bool T = true;

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = r.Next(0,11);
                }
            }

            Console.WriteLine();

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    Console.Write(mat[linha, coluna] + " ");
                }
                Console.WriteLine();
            }
        

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for(int coluna = 0;coluna < mat.GetLength(1); coluna++)
                {
                   
                    if (linha > coluna && mat[linha,coluna] != 0)
                    {
                        T = false;
                      
                    }
                }

            }
            if (T)
            {

                Console.WriteLine("A matriz é triangular");
            }

            else
            {

                Console.WriteLine("A matriz não é triangular");
            }

            Console.ReadLine();
        }
    }
}
