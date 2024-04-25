
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

        public static void For0toNum(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Número: " + i);
            }
        }
        public static void For_i_j(int j)
        {
            int i;
            for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}")) ;
        }
        public static void Foreach_(int[] nums)
        {
            foreach (int i in nums)
            {
                Console.WriteLine("Número: " + i);
            }
        }
        public static void While_(int num)
        {
            while (num > 0)
            {
                Console.WriteLine("Número: " + num);
                num--;
            }
        }
        public static void DoWhile_(int num)
        {
            do
            {
                Console.WriteLine("Número: " + num);
                num--;
            } while (num > 0);

        }
    }
}