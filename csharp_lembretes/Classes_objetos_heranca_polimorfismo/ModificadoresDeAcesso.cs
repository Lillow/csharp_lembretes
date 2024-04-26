namespace csharp_lembretes.Classes_objetos_heranca_polimorfismo;

internal class ModificadoresDeAcesso
{
    public int Publico
    {//Todos tem acesso
        get {return privado; }

        set
        {
            privado = value;
        } } 

    private int privado; //Apenas a classe tem acesso
    
}
