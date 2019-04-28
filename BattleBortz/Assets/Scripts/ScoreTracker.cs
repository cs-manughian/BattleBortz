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

    public void UpdateHealth(int damage)
    {
        health -= damage;
        OnHealthChanged?.Invoke(health);
    }
}
