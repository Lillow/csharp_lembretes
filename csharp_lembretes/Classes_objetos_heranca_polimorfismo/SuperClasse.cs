namespace csharp_lembretes.Classes_objetos_heranca_polimorfismo
{
    internal class SuperClasse(string nomeClasse) : INterface /*Implementar interface*/
    {
        private static readonly string campo = "campo"; // Campo statico, privado, somente leitura
        public string NomeClasse { get; } = nomeClasse;

        public string? MyProperty3 { get; set; } // Propriedade que permite nulo

        // "prop" atalho para criar uma propriedade mais rápido
        public int MyProperty { get; set; } // Propriedade que possui get e set

        public static string MyProperty1 // Propriedade que possui get exemplo
        {
            get
            {
                return ( $"Exemplo {campo}");
            }
        }

        public static string MyProperty2 => ($"Exemplo: {campo}");// Mesma coisa do anterior com Lambda


        public virtual string  MetodoAbstrato() => "Método que pode ser herdado da Super Classe";
    }
}
