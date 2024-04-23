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
}
