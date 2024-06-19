using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EXERCICIO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            double[,] mat = new double[3, 3];

            Console.WriteLine("Matriz Original");

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = r.Next(0,11);
                    Console.Write(mat[linha, coluna] + " ");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
              
                mat[linha, linha] = Math.Sqrt(mat[linha, linha]);
               
                
            }
            Console.WriteLine("Matriz Modificada");

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for(int coluna = 0;coluna < mat.GetLength(1); coluna++)
                {
                     Console.Write(mat[linha, coluna] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
