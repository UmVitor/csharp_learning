using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //double[,] mat = new double[4,3]; // instancia na memória uma matrix de 2 linhas e 3 colunas
            //Console.WriteLine(mat.Length); // retorna quantos elementos a matriz tem no total
            //Console.WriteLine(mat.Rank); // retorna o número de dimensões do Array
            //Console.WriteLine(mat.GetLength(0)); // Retorna o número de linhas da matriz
            //Console.WriteLine(mat.GetLength(1)); // Retorna o número de Colunas da matriz

            //Exercício: Fazer um programa par ler um número interio N e uma matriz de ordem N contrndo números inteiros.
            //Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz
            
            Console.Write("Ordem da matriz: ");
            int aux = 0;
            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N,N];
            for(int i=0;i<N;i++){
                for(int k=0;k<N;k++){
                    mat[i,k] = int.Parse(Console.ReadLine());  
                    if(mat[i,k] < 0 ){
                        aux++;
                    }
                }
            }

            Console.WriteLine("A matriz possui " + aux + " numeros negativos.");
            ImprimeMatriz(mat);            
            ImprimeMatrizDiagonal(mat);



        }
        static void ImprimeMatriz(int[,] m){
            Console.WriteLine("------------Matriz------------");
            for(int i=0;i<m.GetLength(0);i++){
                for(int k=0;k<m.GetLength(1);k++){
                    Console.Write(m[i,k] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ImprimeMatrizDiagonal(int[,] m){
            Console.WriteLine("------------Diagonal------------");
            int i=0;
            for(;i<m.GetLength(0);i++){                
                for(int k=0; k<i;k++) {
                    Console.Write(" ");
                }                    
                Console.Write(m[i,i]);
                Console.WriteLine();
            }
        
        }
    }
}
