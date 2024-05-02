namespace csharp_lembretes.GerenciarPacotes;

internal class Math_
{
    public static double Potencia(double num1, double num2)
    {//Potência

        return Math.Pow(num1, num2);
    }

    //Trigonometria
    public static double Seno(double angulo)
    {//Seno
        var seno = Math.Sin(angulo * Math.PI / 180);
        return Math.Round(seno, 4);
    }

    public static double Coseneno(double angulo)
    {//Coseneno
        var coseneno = Math.Cos(angulo * Math.PI / 180);
        return Math.Round(coseneno, 4);
    }

    public static double Tangente(double angulo)
    {//Tangente
        var tangente = Math.Tan(angulo * Math.PI / 180);
        return Math.Round(tangente, 4);

    }

    //Raiz quadrada
    public static double RaizQuadrada(double num)
    {
        return Math.Sqrt(num);
    }
}
