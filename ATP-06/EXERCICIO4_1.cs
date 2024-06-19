using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int somaI;
            double soma2 = 0,soma4 = 0,media2, media4;
          
          Random r = new Random();
          int[,] mat = new int[3, 6];

            Console.WriteLine("Matriz Original");

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = r.Next(0, 11);
                    Console.Write(mat[linha, coluna] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Matriz Alterada");

            for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
            {

                if (coluna % 2 != 0)
                {
                    somaI = 0;
                   for (int linha = 0; linha < mat.GetLength(0); linha++)
                   {
                        if (mat[linha, coluna] % 2 != 0)
                        {
                            somaI += mat[linha, coluna] ;
                        }        
                        
                   }
                    Console.WriteLine($"A soma dos números ímpares são da coluna {coluna + 1}: {somaI}");
                    
                }
               
            }
              Console.WriteLine();
          
            for (int linha = 0;linha < mat.GetLength(0); linha++)
            {

                soma2 += mat[linha, 1] ;
                soma4 += mat[linha, 3] ;
                
            }
            media2 = soma2 / mat.GetLength(0);
            media4 = soma4 / mat.GetLength(0);

            Console.WriteLine($"A média Aritmética da segunda coluna é: " + media2);
            Console.WriteLine($"A média Aritmética da quarta coluna é: " + media4);

            for (int coluna = 0;coluna < 3;coluna++)
            {
                mat[coluna, 5] = mat[coluna, 0] + mat[coluna, 1];
            }
            Console.WriteLine() ;
            
            Console.WriteLine("Matriz Alterada");

            for(int linha = 0;linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1);coluna++)
                {
                    Console.Write(mat[linha,coluna] + " ");
                }
                Console.WriteLine();
            }
           
            Console.ReadLine();
           
        }
    }
}
