using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lembretes.Classes_objetos_heranca_polimorfismo
{
    public class SuperClasse
    {
        const string atributo = "atributo"; // Atributo
        public string Propriedade { get; } // Pripriedade que pussui apenas get

        // "prop" atalho para criar uma propriedade mais rápido
        public int MyProperty { get; set; } // Propriedade que possui get e set

        public static string MyProperty1 // Propriedade que possui get exemplo
        {
            get
            {
                return ( $"Exemplo {atributo}");
            }
        }

        public static string MyProperty2 => ($"Exemplo {atributo}");// Mesma coisa do anterior com Lambda



        public SuperClasse(string nomeClasse)
        {
            this.Propriedade = nomeClasse;

        }

        
    public static String MetodoAbstrato()
        {
            return "Método Abstrato Super Classe";
        }
    }
}
