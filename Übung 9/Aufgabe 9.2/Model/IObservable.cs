public interface IObservable {
    void Register(IObserver observer);

    void UnRegister(IObserver observer);

    void UpdateAllObservers();
}