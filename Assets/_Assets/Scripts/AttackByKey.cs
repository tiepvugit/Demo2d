using UnityEngine;

public class AttackByKey : MonoBehaviour
{

    private const string AttackParamName = "attack";
    [SerializeField] private Animator animator;
    [SerializeField] private KeyCode attackKey;

    [SerializeField] private Transform bitePoint;
    [SerializeField] private float biteRadius;

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
        var hit = Physics2D.CircleCast(bitePoint.position, biteRadius,transform.right);
        if(hit.transform != transform)
        {

        }
    }


    private void Update()
    {
        CheckAttackInput();
    }
}
