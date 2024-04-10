using UnityEngine;

public class PlayerPrefsFloatReader : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private float value;
    [ContextMenu("Get")]
    public float Get()
    {
        value = PlayerPrefs.GetFloat(keyName, value);
        return value;
    }
}