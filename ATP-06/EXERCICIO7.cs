using System;

namespace MatrizAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] mat = new int[10, 4];
            int notaM = int.MinValue;
            int notaF = -1;
            double somaNota = 0;
            double mediaNotas = 0;

            
            for (int coluna = 0; coluna < 10; coluna++)
            {
                Console.WriteLine($"Aluno {coluna + 1}:");
                Console.Write("Informe o número da matrícula: ");
                mat[coluna, 0] = int.Parse(Console.ReadLine());
                Console.Write("Informe a média das provas: ");
                mat[coluna, 1] = int.Parse(Console.ReadLine());
                Console.Write("Informe a média dos trabalhos: ");
                mat[coluna, 2] = int.Parse(Console.ReadLine());

                mat[coluna, 3] = mat[coluna, 1] + mat[coluna, 2];

                
                if (mat[coluna, 3] > notaM)
                {
                    notaM = mat[coluna, 3];
                    notaM = coluna;
                }

                
                somaNota += mat[coluna, 3];
            }

            
             mediaNotas = somaNota / 10;

           
            Console.WriteLine($"A matrícula do aluno com a maior nota final é: {mat[notaM, 0]}");

            
            Console.WriteLine($"A média aritmética das notas finais é: {mediaNotas}");
            Console.ReadLine();
        }

    }
}
