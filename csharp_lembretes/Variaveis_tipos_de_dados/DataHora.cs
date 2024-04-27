using System.Globalization;

namespace csharp_lembretes.Variaveis_tipos_de_dados;

internal class DataHora(DateTime dataHora)
{
    public static DateTime Agora { get; } = DateTime.Now;

    public static DateTime AgoraMais5dias { get; } = Agora.AddDays(5);

    public string DataString1 { get; } = dataHora.ToString("dd-MMMM-yyyy HH:mm");
    public string DataString2 { get; } = dataHora.ToString("dd-MM-yyyy HH:mm");

    public string DataCurta { get;} = dataHora.ToShortDateString();

    public string HoraCurta { get; } = dataHora.ToShortTimeString();

    public static DateTime StringParaData(string data)
    {
        return DateTime.Parse(data);
    }

    public static void StringParaData2(string data)
    {

      var sucesso =   DateTime.TryParseExact(data, 
             "yyyy-MM-dd HH:mm", 
             CultureInfo.InvariantCulture, 
             DateTimeStyles.None, 
             out DateTime date);
      if (sucesso)  Console.WriteLine(date.ToString());
      else Console.WriteLine("Data inválida");
    }
}
