
namespace csharp_lembretes.Estruturas_de_controle
{
    internal class Repeticao
    {
        //public void awaitforeach()
        //{

        //    await foreach (var item in GenerateSequenceAsync())
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        public void for_(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Número: " + i);
            }
        }

        public void for_(int num1, int num2)
        {
            int i;
            int j = 3;
            for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}")) ;
        }

        public void foreach_(int[] nums)
        {
            foreach (int i in nums)
            {
                Console.WriteLine("Número: " + i);
            }
        }

        public void while_(int num)
        {
            while (num > 0)
            {
                Console.WriteLine("Número: " + num);
                num--;
            }
        }



        public void doWhile_(int num)
        {
            do
            {
                Console.WriteLine("Número: " + num);
                num--;
            } while (num > 0);

        }
    }
}