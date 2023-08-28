public interface IObserver
{
    void OnNotify(Subject subject, ObserverEvent observerEvent);
}