public class VfxManager : IObserver
{
    // ... kode lain ...

    public void OnNotify(Subject subject, ObserverEvent observerEvent)
    {
        if (observerEvent == ObserverEvent.Damaged)
        {
            // Mengaktifkan efek visual ketika pemain terluka
        }
    }
}