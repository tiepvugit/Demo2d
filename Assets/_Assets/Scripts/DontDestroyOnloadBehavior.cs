using UnityEngine;

public class DontDestroyOnloadBehavior : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
