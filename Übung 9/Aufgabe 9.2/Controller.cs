using Aufgabe_9._2.Pages;

public class Controller : IObserver
{
    private DiceWithMemory _DiceWithMemory;

    private DiceView _DiceView;
    public void Update(IObservable observable)
    {
        var diceWithMemory = observable as DiceWithMemory;
        _DiceWithMemory = diceWithMemory;
    }

    public void Init(DiceWithMemory diceWithMemory, DiceView diceView) => (_DiceWithMemory, _DiceView) = (diceWithMemory, diceView);

    public int RollDice(int low, int high) => _DiceWithMemory.Roll(low, high);
    
}