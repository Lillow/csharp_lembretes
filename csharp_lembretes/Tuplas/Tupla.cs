namespace csharp_lembretes.Tuplas;

/*** Teste
Tupla tupla = new Tupla("Danillo", "Silva");
Console.WriteLine($"Id: {tupla.Prop1.Item1}");
Console.WriteLine(tupla.Prop1.Item2);
Console.WriteLine(tupla.Prop1.Item3);

tupla = new Tupla("João", "Silva");
Console.WriteLine($"Id: {tupla.Prop1.Item1}");
Console.WriteLine(tupla.Prop1.Item2);
Console.WriteLine(tupla.Prop1.Item3);

tupla = new Tupla("Maria", "Silva");
Console.WriteLine($"Id: {tupla.Prop1.Item1}");
Console.WriteLine(tupla.Prop1.Item2);
Console.WriteLine(tupla.Prop1.Item3);

tupla.Prop2 = (-1, "Luiza", "Soriano");
Console.WriteLine($"Id: {tupla.Prop2.Item1}");
Console.WriteLine(tupla.Prop2.Item2);
Console.WriteLine(tupla.Prop2.Item3);

var tupla2 = Tupla.OutroExemplo( "Lucia", "Marinho");
Console.WriteLine($"Id: {tupla2.Item1}");
Console.WriteLine(tupla2.Item2);
Console.WriteLine(tupla2.Item3);

tupla.Prop0 = tupla.Prop1;
Console.WriteLine($"Id: {tupla.Prop0.Id}");
Console.WriteLine(tupla.Prop0.nome);
Console.WriteLine(tupla.Prop0.sobrenome);
*******/

/***Exemplo de uso
//var tuplaArquivo = Arquivo.LerArquivoReturnTupla("Arquivao.txt");
var (sucesso, linhas, nLinhas) = Arquivo.LerArquivoReturnTupla("Arquivao.txt");
if (sucesso) Console.WriteLine("Sucesso");
else Console.WriteLine("Falha");
Console.WriteLine($"Número de linhas: {nLinhas}");
foreach (var linha in linhas)
{
    Console.WriteLine(linha);
}
***/
internal class Tupla
{
    public Tupla(string nome, string sobrenome)
    {
        Prop1 = (Count, nome, sobrenome);
        Count++;
    }

    public (int Id, string nome, string sobrenome) Prop0 { get; set; }
    public (int, string, string) Prop1 { get; set; }
    public ValueTuple<int, string, string> Prop2 { get; set; }
    private static int Count = 0;

    public static Tuple<int, string, string> OutroExemplo(string nome, string sobrenome)
    {
        var tupla = Tuple.Create(Count, nome, sobrenome);
        Count++;
        return tupla;
    }
}
