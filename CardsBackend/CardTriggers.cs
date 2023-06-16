using MoonSharp.Interpreter;

namespace CardsBackend;

[MoonSharpUserData]
public class CardTriggers
{
    [MoonSharpHidden] public Dictionary<string, Closure> Triggers { get; private set; } = new();

    public Closure this[string k]
    {
        get => this.Triggers[k];
    }

    public void SetTrigger(string trigger, Closure fn)
    {
        Triggers[trigger] = fn;
    }
}