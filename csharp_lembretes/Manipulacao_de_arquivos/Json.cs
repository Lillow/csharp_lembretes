using System.Text.Json;

namespace csharp_lembretes.Manipulacao_de_arquivos;

internal class Json
{
    public static void GerarArquivoJson(string nomeArquivo, string conteudoArquivo)
    {
        //Serializar Json
        string json = JsonSerializer.Serialize(new
        {
            nome = nomeArquivo,
            conteudo = conteudoArquivo
        });
        string nomeDoArquivo = $"{nomeArquivo}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
