namespace csharp_lembretes.Colecoes;

internal class Pilha
{
    public Pilha(int elementos)
    {
        for (int i = 0; i < elementos; i++)
        {
            pilha.Push(i + 1); //Insere elemento ao topo da pilha
        }
    }

    Stack<int> pilha = new Stack<int>();

    public void MostrarElemtos()
    {
        foreach (var elemento in pilha)
        {
            Console.WriteLine(elemento);
        }
    }

    public void RemoverElemto()
    {
        pilha.Pop(); // Remove sempre o topo da pilha
    }
}

