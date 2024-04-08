using UnityEngine;

public class CrounchByKey : MonoBehaviour
{
    private const string IsCrounchParamName = "isCrouching";
    [SerializeField] private Animator animator;
    [SerializeField] private KeyCode crouchKey;

    private void CheckDownArrow()
    {
        var isCrounching = Input.GetKey(crouchKey);
        animator.SetBool(IsCrounchParamName, isCrounching);
        if (isCrounching)
        { 
            Debug.Log(IsCrounchParamName);
        }
    }

    private void Update()
    {
        CheckDownArrow();
    }

}
