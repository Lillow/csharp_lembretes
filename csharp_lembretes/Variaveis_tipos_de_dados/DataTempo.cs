using System.Reflection.Metadata;

namespace csharp_lembretes.Variaveis_tipos_de_dados
{
    internal class DataTempo
    {
        public DataTempo() 
        { 
             DateTime dataAtual = DateTime.Now;
             DateTime dataAtualMais5dias = DateTime.Now.AddDays(5);

            Console.WriteLine(dataAtual.ToString("dd/MMMM/yyyy HH:mm"));
        
        
        }

        

    }
}
