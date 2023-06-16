using MoonSharp.Interpreter;

namespace CardsBackend;

public static class CardManager
{
    public static string CardPath = "Data/Cards";
    
    public static Dictionary<int, CardStaticData> StaticData = new();

    public static void LoadCards()
    {
        string cardDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CardPath);
        int cardId = 0;

        UserData.RegisterType<CardStaticData>();
        
        foreach (string file in Directory.EnumerateFiles(cardDir))
        {
            if (file.EndsWith(".lua"))
            {
                string script = File.ReadAllText(file);
                CardStaticData cardData = new();
                Script interp = new Script(CoreModules.Preset_HardSandbox);
                
                interp.Globals["setTrigger"] = (Action<string, Closure>) (cardData.Triggers.SetTrigger);
                interp.Globals["setMetadata"] = (Action<Table>) (cardData.SetMetadata);
                
                interp.DoString(script);

                StaticData[cardId++] = cardData;
            }
        }
        
        Console.WriteLine($"Loaded {cardId} cards.");
    }
}