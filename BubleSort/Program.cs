using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 7, 3, 9, 2, 5, 0};
            Console.WriteLine("Array original\n");
            foreach (int numero in numeros)
                Console.Write($"{numero} ");
            Console.WriteLine("\n\nOrdenando o array usando Bubble Short\n");
            int[] arrayOrdenado = IntArrayBubbleSort(numeros);
            Console.WriteLine("Array Ordenado\n");
            foreach (int numero in arrayOrdenado)
                Console.Write($"{numero} ");
            Console.ReadLine();
        }

        private static int[] IntArrayBubbleSort(int[] numeros)
        {
            for(int ultimo = numeros.Length - 1; ultimo > 0; ultimo--) //Variação dos elementos: Começando pelo último adjacente da posição do vetor. Enquanto eu tenho elementos para serem avaliados sigo com a repetição e decremento a variável 'ultimo', e ela determina os elementos que serão empurrados para a última posição;
            {
                for (int i = 0; i < ultimo; i++)     // Processamento: Onde (i) é uma var auxiliar; Enquanto i < ultimo, continue.
                {
                    if (numeros[i] > numeros[i + 1]) // Verificação de pares adjacentes do vetor: Onde [] é o índice. Se for true, continue.
                        TrocarElementos(numeros, i, i + 1); //Troque os elementos
                } 
            }
            return numeros;
        }

        private static void TrocarElementos(int[] numeros, int i, int v)
        {
            int aux = numeros[i];
            numeros[i] = numeros[v]; //Troca as posição dos elementos;
            numeros[v] = aux;

        }
    }
}
