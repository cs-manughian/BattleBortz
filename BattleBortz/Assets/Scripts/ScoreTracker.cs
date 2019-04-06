using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    int health = 100;

    public delegate void HealthChangedEvent(int health);
    public event HealthChangedEvent OnHealthChanged;

    void Start()
    {
        OnHealthChanged?.Invoke(health);
    }

    void OnCollisionEnter(Collision collision)
    {
        bool collidedWithOtherPlayer = collision.gameObject.tag != gameObject.tag;
        if (collidedWithOtherPlayer)
        {
            health -= 10;
            OnHealthChanged?.Invoke(health);
        }
    }
}
