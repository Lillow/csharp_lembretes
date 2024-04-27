using System.Globalization;
using System.Runtime.Serialization;

namespace csharp_lembretes.Variaveis_tipos_de_dados;

internal class FormatacoesReais(float valor)
{
    private readonly float valor = valor;

    public string Real
    {
        get 
        {
            return $"{this.valor:C}"; //Formatar em moeda R$ 
        } 
    }

    public string Dolar_Sistema
    {
        get
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("c"); //Muda região do sistema
            return $"{this.valor:C}"; //Formatar em moeda $ en-US
        }
    }

    public string Dolar
    {
        get
        {
            // Formatar em $ en-US sem mudar o idioma do sitema inteiro
            return $"{this.valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}"; //Formatar em moeda $
        }
    }

    public string Casas
    {
        get
        {
            return $"{this.valor.ToString("N4")}"; // Formatar con 4 casas decimais
        }
    }

    public string Porcento
    {
        get
        {
            return $"{this.valor.ToString("P")}"; //Formatar em porcentagem
        }
    }

    public string FormatarPersonalizado
    {
        get
        {
            return $"{this.valor.ToString("#_#_#")}"; //Formatar em porcentagem
        }
    }
}
