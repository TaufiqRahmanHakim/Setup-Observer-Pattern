public class SoundManager : IObserver
{
    // ... kode lain ...

    public void OnNotify(Subject subject, ObserverEvent observerEvent)
    {
        if (observerEvent == ObserverEvent.Damaged)
        {
            // Mengaktifkan logika suara ketika pemain terluka
        }
    }
}