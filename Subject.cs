public class Subject
{
    private List<IObserver> observers = new List<IObserver>();

    public void AttachObserver(IObserver observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
        }
    }

    public void DetachObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    protected void Notify(ObserverEvent observerEvent)
    {
        foreach (var observer in observers)
        {
            observer.OnNotify(this, observerEvent);
        }
    }
}
