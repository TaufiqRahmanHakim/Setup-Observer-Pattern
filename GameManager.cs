public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Subject Subject { get; private set; }

    private void Awake()
    {
        Instance = this;
        Subject = new Subject();
    }

    public void PlayerDamaged()
    {
        Subject.Notify(ObserverEvent.Damaged);
    }
}