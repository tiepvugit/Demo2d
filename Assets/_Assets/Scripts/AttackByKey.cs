using UnityEngine;

public class AttackByKey : MonoBehaviour
{

    private const string AttackParamName = "attack";
    [SerializeField] private Animator animator;
    [SerializeField] private KeyCode attackKey;

    [SerializeField] private Transform bitePoint;
    [SerializeField] private float biteRadius;
    [SerializeField] private int damage;
    private void CheckAttackInput()
    {
        if (Input.GetKeyDown(attackKey))
        {
            Debug.Log(AttackParamName);
            animator.SetTrigger(AttackParamName);

        }
    }

    public void OnAttackCallback()
    {
        Debug.Log("OnAttackCallback");
        var hit = Physics2D.CircleCast(bitePoint.position, biteRadius, transform.right);
        Debug.Log($"hit : {hit.point}");
        Debug.Log($"hit something: {hit.transform.name}");
        if (hit.transform != transform)
        {
            var health = hit.transform.GetComponent<HealthComponent>();
            health?.TakeDamage(damage);
        }
        else
        {
            Debug.Log($"hit something: {hit.transform.name}");
        }
    }
    private void Update()
    {
        CheckAttackInput();
    }
}
