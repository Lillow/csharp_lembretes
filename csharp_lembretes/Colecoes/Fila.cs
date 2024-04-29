namespace csharp_lembretes.Colecoes;

internal class Fila
{
    //Adiciona e exclui em ordem de fila 

    public Fila(int elementos)
    {
        for (int i = 0; i < elementos; i++)
        {
            fila.Enqueue(i + 1);
        }
    }
    
    public  Queue<int> fila = new();

    public  void MostrarElemtos()
    {
        foreach (var elemento in fila)
        {
            Console.WriteLine(elemento);
        }
    }

    public void RemoverElemto()
    {
        fila.Dequeue();
    }// Remove sempre o primeiro da fila


}
