using UnityEngine;

public class JumpByKey : MonoBehaviour
{

    private const string JumpParamName = "jump";
    [SerializeField] private Animator animator;
    [SerializeField] private Vector2 jumpDirection;
    [SerializeField] private Rigidbody2D rig2D;
    [SerializeField] private KeyCode jumpKey;
    private void CheckUpArrow()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Debug.Log(JumpParamName);
            animator.SetTrigger(JumpParamName);
            rig2D.AddForce(jumpDirection);
        }
    }

    private void Update()
    {
        CheckUpArrow();
    }

}