namespace csharp_lembretes.Colecoes;

internal class Arrays
{
    public static void Vetor()
    {
        int[] numeros = new int[5]; // Declarando e inicializando array de 5 posições

        int[] initArray = [1, 2, 3, 4]; // Declarando e inicializando array

        initArray[0] = 2; // Trocando o valor da posição 0

        Console.WriteLine($"Tamanho do array:  {numeros.Length}"); // Tabanho do array
    }

    public static void Matriz()
    {

        int[,] multiDimensionalArray1 = new int[2, 3]; // Declara Array com duas dimenções

        Console.WriteLine(multiDimensionalArray1.Length);

        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };// Declarando e inicializando array com duas dimenções

        Console.WriteLine(multiDimensionalArray2.Length);

        int[][] jaggedArray = new int[6][]; // Declara um array irregular

        // Defina os valores do primeiro array na estrutura de array irregular
        jaggedArray[0] = [1, 2, 3, 4];

    }

    public static void RedimencionarArray(int[] array) 
    {
        Console.WriteLine($"Tamanho do array:  {array.Length}");

        Array.Resize(ref array, array.Length * 2); // Redimenciona o Array

        Console.WriteLine($"Tamanho do array depois do Resize:  {array.Length}");
    }

    public static void CopiarArray(int[] array)
    {
        Console.WriteLine("Array:");
        foreach (int i in array)
        {
            Console.WriteLine(i);
        } 
        int[] arrayCopia = new int[array.Length * 2];
        Array.Copy(array, arrayCopia, array.Length); // Copia um array para um outro
        Console.WriteLine("Array cópia:");
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
}
