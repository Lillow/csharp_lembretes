namespace csharp_lembretes.Colecoes
{
    internal class Colecoes
    {
        public void Arrays()
        {
            int[] numeros = new int[5]; // Declarando e inicializando array de 5 posições

            int[] initArray = { 1, 2, 3, 4 }; // Declarando e inicializando array

            initArray[0] = 2; // Trocando o valor da posição 0

            Console.WriteLine(numeros.Length); // Tabanho do array

        }

        public void Matriz()
        {

            int[,] multiDimensionalArray1 = new int[2, 3]; // Declara Array com duas dimenções

            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };// Declarando e inicializando array com duas dimenções


            int[][] jaggedArray = new int[6][]; // Declara um array irregular

            // Defina os valores do primeiro array na estrutura de array irregular
            jaggedArray[0] = [1, 2, 3, 4];

        }

        public void Lists()
        {
            List<int> numeros = new List<int>(); // Declarando e inicializando arrayList

            numeros.Add(31); // Adiciona um valor ao final da lista

            Console.WriteLine(numeros.Count); // Numero de itens la lista

            numeros.Remove(0); // Remove elemento da posição 0

            Console.WriteLine(numeros[0]); //Pega elemento na posição 0
        }

        public void Dicionario()
        {
            Dictionary<string, List<int>> dicionario = new Dictionary<string, List<int>>();

            dicionario.Add("chave1", [1, 2, 3, 4, 5, 6, 7, 8]);
            dicionario.Add("chave2", [1, 2, 3, 4, 5, 6, 7, 8]);

            dicionario["chave1"].Add(10); //Adiciona o valor 10 a chave 1 do dicionário


            foreach (var key in dicionario.Keys)
            {
                Console.WriteLine(key); // Exibir chave do dicionário

                foreach (var valor in dicionario[key])
                {
                    Console.WriteLine(valor); // Exibir valores do dicionário
                }


            }



        }
    }
}
