public class Player : IObserver
{
    // ... kode lain ...

    public void OnNotify(Subject subject, ObserverEvent observerEvent)
    {
        if (observerEvent == ObserverEvent.Damaged)
        {
            // Mengaktifkan logika ketika pemain terluka
        }
    }
}