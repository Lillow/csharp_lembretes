namespace csharp_lembretes.Classes_objetos_heranca_polimorfismo
{
    internal sealed class SubClasse(string nomeClasse) : SuperClasse(nomeClasse), INterface //Classe selada
    {
        public sealed override string MetodoAbstrato() //Método selado
        {
            base.MetodoAbstrato(); //Chama o método da Super Classe
            return "Método Abstrato da Sub Classe";

        } 
    }
}
