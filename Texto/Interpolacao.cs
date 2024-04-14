namespace csharp_lembretes.Texto
{
        internal class Interpolacao
        {
            public Interpolacao(string texto)
            {

                const string interpolacao1 = "${conteúdo}";
                const string interpolacao2 = "{index}, conteúdo";
                Console.WriteLine($"Exemplo com {interpolacao1}, {texto}!");
                Console.WriteLine("Exemplo com {0}, {1}!", interpolacao2, texto);
            }
        }
}
