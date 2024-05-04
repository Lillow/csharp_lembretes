namespace csharp_lembretes.Texto;

internal class Outros
{
    public static void TamanhoTexto(string texto)
    {
        Console.WriteLine(texto.Length);
    }

    public static void VeificarSeContemSeqComum(string texto)
    {
        // Verificando se a senha contém sequências comuns
        string[] sequenciasComuns = { "123456", "abcdef" };
        if (sequenciasComuns.Any(s => texto.Contains(s)))
            Console.WriteLine("Sua senha contem uma sequencia comum. Tente uma senha mais complexa.");
    }

    public static void VeificarSeContemPalComum(string texto)
    {
        // Verificando se a senha contém palavras comuns
        string[] palavrasComuns = { "password", "123456", "qwerty" };
        if (palavrasComuns.Contains(texto))
            Console.WriteLine("Sua senha e muito comum. Tente uma senha mais complexa.");

    }

    public static void VeificarSeContemNumero(string texto)
    {
        var temNumero = texto.Any(char.IsDigit);
        if (temNumero) Console.WriteLine("Tem número.");
    }
    public static void VeificarSeContemCaracEspeciais(string texto)
    {
        var temCaractereEspecial = texto.Any(c => !char.IsLetterOrDigit(c));
        if (temCaractereEspecial) Console.WriteLine("Tem caracteres especiais.");
    }

}
