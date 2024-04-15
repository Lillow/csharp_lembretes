namespace csharp_lembretes.Colecoes
{
    internal class Arrays
    {
        public void Vetor()
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
    }
}
