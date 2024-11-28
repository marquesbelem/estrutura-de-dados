using System;
using System.Reflection;

namespace estrutura_de_dados.Search
{
    // Busca binária = Algoritmo de busca que encontra a posição de um valor-alvo dentro de um array ordenado.
    // Metade do array é eliminada a cada "passo"
    // Complexidade de tempo de execução: O(log n)

    // Desvantagens:
    // - Não é eficiente para conjunto de dados pequeno

    // Vantagens:
    // - Rápido para buscas em conjuntos de dados grande (ex.1 milhão)

    public class BinarySearch
    {
        public void Search()
        {
            int[] array = new int[1000000];
            int target = 777777;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            //int index = array.ToList().BinarySearch(target);
            int index = FindIndex(array, target);

            if (index == -1)
            {
                Console.WriteLine($"{target} not found");
                return;
            }

            Console.WriteLine($"Element found at index {index}");
        }

        private int FindIndex(int[] array, int target)
        {
            int lowIndex = 0;
            int highIndex = array.Length - 1;

            while (lowIndex <= highIndex)
            {
                int middleIndex = lowIndex + (highIndex - lowIndex) / 2;
                int value = array[middleIndex];

                if (value < target) lowIndex = middleIndex + 1; 
                else if (value > target) highIndex = middleIndex - 1;
                else return middleIndex; //target found
            }

            return -1;
        }
    }
}
