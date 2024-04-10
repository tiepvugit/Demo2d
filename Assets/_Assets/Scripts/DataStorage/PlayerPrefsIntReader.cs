using UnityEngine;

public class PlayerPrefsIntReader : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private int value;
    [ContextMenu("Get")]
    public int Get()
    {
        value = PlayerPrefs.GetInt(keyName, value);
        return value;
    }
}
