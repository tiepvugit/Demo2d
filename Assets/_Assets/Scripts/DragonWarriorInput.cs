using UnityEngine;
using UnityEngine.Events;

public class DragonWarriorInput : MonoBehaviour
{
    private const string IsCrounchParamName = "isCrouching";
    private const string IsWalkingParamName = "isWalking";
    private const string JumpParamName = "jump";
    private const string AttackParamName = "attack";
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Vector2 jumpDirection;
    [SerializeField] private Vector2 moveDirection;
    [SerializeField] private Rigidbody2D rig2D;

    private void CheckHorizontalInput()
    {
        var isWalking = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow);
        var direction = moveDirection;
        if (isWalking)
        {
            var isFlip = Input.GetKey(KeyCode.LeftArrow);
            spriteRenderer.flipX = isFlip;
            if (isFlip)
                direction *= -1;
            rig2D.velocity = direction;
        }

        animator.SetBool(IsWalkingParamName, isWalking);
        if (isWalking)
            Debug.Log(IsWalkingParamName);
    }

    private void CheckDownArrow()
    {
        var isCrounching = Input.GetKey(KeyCode.DownArrow);
        animator.SetBool(IsCrounchParamName, isCrounching);
        if (isCrounching)
        {
            Debug.Log(IsCrounchParamName);
        }
    }

    private void CheckUpArrow()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(JumpParamName);
            animator.SetTrigger(JumpParamName);
            rig2D.AddForce(jumpDirection);
        }
    }


    private void CheckAttackInput()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log(AttackParamName);
            animator.SetTrigger(AttackParamName);

        }
    }
    private UnityEvent inputs;

    private void Start()
    {
        inputs = new UnityEvent();
        inputs.AddListener(CheckHorizontalInput);
        inputs.AddListener(CheckDownArrow);
        inputs.AddListener(CheckUpArrow);
        inputs.AddListener(CheckAttackInput);
    }


    public void OnAttackCallback()
    {
        Debug.Log("OnAttackCallback");

    }

    private void OnValidate()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        inputs?.Invoke();
    }


}
