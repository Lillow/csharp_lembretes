namespace csharp_lembretes.Manipulacao_de_arquivos;

internal class Arquivo
{
    public static void Criar(string nome, string conteudo)
    {
        string nomeDoArquivo = $"{nome}";

        File.WriteAllText(nomeDoArquivo, conteudo); //Criar arquivo
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }

    public static void LerTodoTexto(string nome) 
    {
        string linhas = File.ReadAllText(nome);
        Console.WriteLine(linhas);
    }

    public static void LerTodasLinhas(string nome)
    {
        string[] linhas = File.ReadAllLines(nome);
        foreach(string line in linhas)
        {
            Console.WriteLine(line.Trim());
        }
    }
}
