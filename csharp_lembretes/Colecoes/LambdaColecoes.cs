namespace csharp_lembretes.Colecoes
{
    internal class LambdaColecoes
    {
        static readonly List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        // FindAll percorre toda a lista e pega os divisiveis por 2 
         readonly List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);

        /***
         * A expressão lambda especifica um parâmetro numero seguido por uma seta (=>) 
         * e uma expressão que retorna um valor booleano. 
         * A função FindAll utiliza essa expressão lambda como critério para 
         * filtrar os números da lista.
         * */

        /***
         * Função lambda que exibe os números pares
         */
        public void GetNumerosPares()
        {
            numerosPares.ForEach(numero => Console.WriteLine(numero));
           
        }




    }
}
