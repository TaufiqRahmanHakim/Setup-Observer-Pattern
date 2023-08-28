public class Camera : IObserver
{
    // ... kode lain ...

    public void OnNotify(Subject subject, ObserverEvent observerEvent)
    {
        if (observerEvent == ObserverEvent.Damaged)
        {
            // Mengaktifkan logika kamera ketika pemain terluka
        }
    }
}