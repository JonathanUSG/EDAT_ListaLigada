using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista Ligada Simple\n");
        var singleList =new SingleList<string>();
        singleList.Add("Juan");
        singleList.Add("José");
        singleList.Add("Alberto");

        Console.WriteLine(singleList);
    }
}