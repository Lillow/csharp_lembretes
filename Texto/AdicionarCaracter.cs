namespace csharp_lembretes.Texto
{
    internal class AdicionaCaracter
    {

        public string AdicionaCaracterEsquerda(int numeroCaractere, char caractere)
        {
            return string.Empty.PadLeft(numeroCaractere, caractere);
        }

        public string AdicionaCaracterDireita(int numeroCaractere, char caractere)
        {
            return string.Empty.PadRight(numeroCaractere, caractere);
        }

    }
}
