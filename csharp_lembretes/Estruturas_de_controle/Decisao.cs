namespace csharp_lembretes.Estruturas_de_controle
{
    internal class Decisao
    {


        public static void IfElse(bool bool1, bool bool2)
        {
            if (bool1 != bool2)
            {
                Console.WriteLine("Diferentes.");
            }
            else if (bool1 == bool2)
            {
                Console.WriteLine("Iguais.");
            }

            else
            {
                Console.WriteLine("oxi!");
            }
        }

        public static void SwitchCase(int num)
        {
            switch (num)
            {
                case 42:
                    Console.WriteLine("Essa é a resposta pra todas as perguntas!");
                    break;
                case 666:
                    Console.WriteLine("Capiroto");
                    break;
                default:
                    Console.WriteLine(":)");
                    break;
            }
        }

        public static void SwitchCaseMin(int num)
        {
            var msg = num switch
            {
                42 => "Essa é a resposta pra todas as perguntas!",
                666 => "Capiroto",
                _ => ":)"
            };

            Console.WriteLine(msg);
        }

        public static string IfTernarioTemperatura(double tempInCelsius)
        {
            return tempInCelsius < 20.0 ? "Cold." : "Perfect!";  

        }

        public static void IfElseDeUmaLinha(int a, int b)
        {
            if (a != b) Console.WriteLine($"a: {a} diferente de b: {b}");
            else Console.WriteLine($"a: {a} igual a b: {b}");
        }

    }
}