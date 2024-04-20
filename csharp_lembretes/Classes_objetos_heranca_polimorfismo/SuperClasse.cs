namespace csharp_lembretes.Classes_objetos_heranca_polimorfismo
{
    internal class SuperClasse(string nomeClasse) : INterface /*Implementar interface*/
    {
        const string atributo = "atributo"; // Atributo
        public string NomeClasse { get; } = nomeClasse;

        // "prop" atalho para criar uma propriedade mais rápido
        public int MyProperty { get; set; } // Propriedade que possui get e set

        public static string MyProperty1 // Propriedade que possui get exemplo
        {
            get
            {
                return ( $"Exemplo {atributo}");
            }
        }

        public static string MyProperty2 => ($"Exemplo: {atributo}");// Mesma coisa do anterior com Lambda


        public virtual string  MetodoAbstrato() => "Método que pode ser herdado da Super Classe";
    }
}
