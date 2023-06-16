using CardsBackend;

namespace CardsBackendTests;

public class EventTests
{ 
    public event InitEvent Init;

    public delegate void InitEvent(CardStaticData staticData);
}
