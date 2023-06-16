using MoonSharp;
using MoonSharp.Interpreter;

namespace CardsBackend;

[MoonSharpUserData]
public class CardStaticData
{
    public void SetMetadata(Table data)
    {
        if (!data.Get("name").IsNilOrNan()) 
            Name = data.Get("name").String;
        if (!data.Get("description").IsNilOrNan()) 
            Description = data.Get("description").String;
        if (!data.Get("health").IsNilOrNan())
            Health = (int) data.Get("health").Number;
        if (!data.Get("power").IsNilOrNan()) 
            Power = (int) data.Get("power").Number;
        if (!data.Get("cost").IsNilOrNan()) 
            Cost = (int) data.Get("cost").Number;
    }

    public string Name { get; set; } = "Card Name";
    public string Description { get; set; } = "Card Description";
    public int Health { get; set; } = 5;
    public int Cost { get; set; } = 1;
    public int Power { get; set; } = 4;

    [MoonSharpHidden] public CardTriggers Triggers { get; set; } = new();
}