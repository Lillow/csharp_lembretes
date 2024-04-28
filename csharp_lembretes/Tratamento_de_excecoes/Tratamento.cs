using csharp_lembretes.Manipulacao_de_arquivos;

namespace csharp_lembretes.Tratamento_de_excecoes;

internal class Tratamento
{
    public void Teste()
    {
        try
        {
            //Expressão a ser testada

        }
        catch (Exception ex)
        {
            // Se cair na excessão
            Console.WriteLine($"Temos um problema: {ex.Message}");
        }
    }

    public static void LerArquivo(string caminho) 
    {
        try
        {
            Arquivo.LerTodasLinhas(caminho);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado");
        }
        catch(DirectoryNotFoundException) 
        {
            Console.WriteLine($"Pasta não encontrada.");
        }
        finally
        {
            Console.WriteLine("Sempre é executado");
        }
    }

    public static void Metodo1()
    {
        try
        {
        Metodo2();

        }
        catch
        {
            Console.WriteLine("Exceção tratada");
        }
    }

    private static void Metodo2()
    {
        Metodo3();
    }
    private static void Metodo3()
    {
        Metodo4();
    }
    private static void Metodo4()
    {
        throw new Exception("Ocorreu uma exceção!");
    }
}
