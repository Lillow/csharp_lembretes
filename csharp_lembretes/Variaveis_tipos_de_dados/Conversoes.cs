//Cast - Casting

namespace csharp_lembretes.Variaveis_tipos_de_dados;

internal class Conversoes
{

    public static void CastExplicito()
    {
        //Classe Convert *Aceita nulo
        string texto = Convert.ToString(565);
        Console.WriteLine("Convert string: " + texto);
        short num1 = Convert.ToInt16(texto);
        int num2 = Convert.ToInt32(texto);
        long num3 = Convert.ToInt64(texto);
        Console.WriteLine($"Convert short: {num1}\nConvert int: {num2}\nConvert long: {num3}");

        texto = null!;
        num2 = Convert.ToInt32(texto);
        Console.WriteLine($"Convert null int: {num2}");



        //Parse *Não aceita nulo
        texto = "2,4";
        float real = float.Parse( texto );
        Console.WriteLine($"Parse float: {real}");

        texto = real.ToString();
        Console.WriteLine($"real.ToString: {texto}");
        //ToString() método da classe Object

    }

    public static void CastExpl()
    {

        int num1 = 42;
        float real1 = num1;
        long num2 = num1;

        Console.WriteLine($"int: {42}\nfloat");

    }

    public static void CastTryParse() 
    {

        string texto = "24a";

        int num;

        _ = int.TryParse(texto, out num); //Tenta converter texto se conseguir, o valor de saída(out) é  num, se não, é 0
        _ = int.TryParse(texto, out int num1);

        Console.WriteLine(num + num1);
    }

}
