using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lembretes.Interpolacao
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
