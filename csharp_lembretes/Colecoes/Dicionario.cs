namespace csharp_lembretes.Colecoes
{
    internal class Dicionario
    {
        public Dicionario()
        {
            Dictionary<string, List<int>> dicionario = new Dictionary<string, List<int>>();

            dicionario.Add("chave1", [1, 2, 3, 4, 5, 6, 7, 8]);
            dicionario.Add("chave2", [1, 2, 3, 4, 5, 6, 7, 8]);

            dicionario["chave1"].Add(10); //Adiciona o valor 10 a chave 1 do dicionário

            List<int> valores = dicionario["chave1"];
            Console.WriteLine(valores.Average()); //Média dos válores

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
