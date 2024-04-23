namespace csharp_lembretes.Manipulacao_de_arquivos;

internal class Arquivo
{
    public static void Criar(string nome, string conteudo)
    {
        string nomeDoArquivo = $"{nome}";

        File.WriteAllText(nomeDoArquivo, conteudo); //Criar arquivo
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
