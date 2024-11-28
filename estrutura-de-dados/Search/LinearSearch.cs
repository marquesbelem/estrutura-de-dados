namespace estrutura_de_dados.Search
{
    // Busca linear - Itera por uma coleção, um elemento por vez
    // Complexidade de tempo de execução: O(n)

    // Desvantagens:
    // - Lento para conjuntos de dados grandes
    
    // Vantagens:
    // - Rápido para buscas em conjuntos de dados pequenos a médios
    // - Não necessita que os dados estejam ordenados
    // - Útil para estruturas de dados que não possuem acesso aleatório (ex: Lista Encadeada)

    public class LinearSearch
    {
        public void Search()
        {
            int[] array = { 2, 5, 1, 9, 3, 8, 10, 11, 12, 13, 14, 15 };
            int index = FindIndex(array, 9);

            if (index == -1)
            {
                Console.WriteLine($"Element not found");
                return;
            }

            Console.WriteLine($"Element found at index {index}");
        }

        private int FindIndex(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
