using CardsBackend;
using MoonSharp.Interpreter;

namespace CardsBackendTests;

public class Program
{

    public static void Main(string[] args)
    {
        CardManager.LoadCards();

        var test = CardManager.StaticData[0];
        
        Console.WriteLine($"Card Name: {test.Name}");
    }
}