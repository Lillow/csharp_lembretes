namespace csharp_lembretes.Classes_objetos_heranca_polimorfismo;

/*Exemplo de uso de Destruct
ConstructDestruct obj = new("ObjetoTeste", 42);
var (nome, id) = obj;
Console.WriteLine(nome + "_" + id);
*/

internal class ConstructDestruct
{
    public ConstructDestruct(string name, int id)
    {
        NomeClasse = name;
        IdClasse = id;
    }

    public void Deconstruct(out string name, out int id) 
    {
        name = NomeClasse;
        id = IdClasse;
    }

    public string NomeClasse { get; set; }
    public int IdClasse { get; set; }
}
