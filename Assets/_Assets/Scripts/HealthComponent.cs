using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int health;
    [SerializeField] private Animator animator;
    private const string AnimationParamName = "die";
    public int Health { get => health; private set => health = value; }
    public bool IsDead => Health <= 0;

    private void Awake()
    {
        Health = MaxHealth;
    }
    public void TakeDamage(int damage)
    {
        Debug.Log($"TakeDamage: {damage}");
        if (IsDead)
            return;
        Health -= damage;
        if (Health <= 0)
            Die();
    }

    public void Heal(int amount)
    {
        if (IsDead)
            return;
        if (Health >= MaxHealth)
            return;
        Health += amount;
    }

    private void Die()
    {
        animator.SetTrigger(AnimationParamName);
        Destroy(gameObject, 1f);
    }
}
