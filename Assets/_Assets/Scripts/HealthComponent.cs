using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int health;

    public int Health { get => health; private set => health = value; }
    public bool IsDead => Health <= 0;

    public int MaxHealth { get => maxHealth;}

    private void Awake()
    {
        Health = MaxHealth;
    }
    public void TakeDamage(int damage)
    {
        if (IsDead)
            return;
        Health -= damage;
    }

    public void Heal(int amount)
    {
        if (IsDead)
            return;
        if (Health >= MaxHealth)
            return;
        Health += amount;
    }
}
