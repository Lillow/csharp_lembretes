namespace csharp_lembretes.Colecoes
{
    internal class Listas
    {
        public void List()
        {
            List<int> numeros = new List<int>(); // Declarando e inicializando arrayList

            numeros.Add(31); // Adiciona um valor ao final da lista

            Console.WriteLine(numeros.Average()); // Calcular média da lista

            Console.WriteLine(numeros.Count); // Numero de itens la lista

            numeros.Remove(0); // Remove elemento da posição 0

            Console.WriteLine(numeros[0]); //Pega elemento na posição 0
        }


        public void LambdaLista()
        {
              List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            // FindAll percorre toda a lista e pega os divisiveis por 2 
             List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);

            /***
             * A expressão lambda especifica um parâmetro numero seguido por uma seta (=>) 
             * e uma expressão que retorna um valor booleano. 
             * A função FindAll utiliza essa expressão lambda como critério para 
             * filtrar os números da lista.
             * */

            /***
             * Função lambda que exibe os números pares
             */

             void GetNumerosPares() => numerosPares.ForEach(numero => Console.WriteLine(numero));


        }
    }
}
