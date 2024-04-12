namespace csharp_lembretes.Estruturas_de_controle
{
    public class Decisao
    {


        public Decisao(bool bool1, bool bool2)
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

        public Decisao(int num)
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
    }
}
