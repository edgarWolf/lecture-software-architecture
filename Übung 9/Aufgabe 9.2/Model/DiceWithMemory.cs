public class DiceWithMemory : IObservable
{
    private List<IObserver> _Observers = new();
    private Dice _Dice = new();

    private List<int> _RollHistory = new();
    public void Register(IObserver observer)
    {
        if (_Observers.Contains(observer)) {
            _Observers.Add(observer);
        }
    }

    public void UnRegister(IObserver observer)
    {
        if (_Observers.Contains(observer)) {
            _Observers.Remove(observer);
        }
    }

    public void UpdateAllObservers() {
        foreach (var observer in _Observers) {
            observer.Update(this);
        }
    }

    public List<int> GetLastFiveRolls()
        => _RollHistory.Skip(Math.Max(0, _RollHistory.Count - 5)).ToList();

    public int GetLatestRoll() => _RollHistory.Last();

    public int Roll(int low, int high) {
        int result = _Dice.Roll(low, high);
        _RollHistory.Add(result);
        UpdateAllObservers();
        return result;
    }
}