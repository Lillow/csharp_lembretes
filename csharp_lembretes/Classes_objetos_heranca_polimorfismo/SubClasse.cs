namespace csharp_lembretes.Classes_objetos_heranca_polimorfismo
{
    internal class SubClasse(string nomeClasse) : SuperClasse(nomeClasse), INterface
    {
        public override string MetodoAbstrato() 
        {
            base.MetodoAbstrato(); //Chama o método da Super Classe
            return "Método Abstrato da Sub Classe";

        } 
    }
}
