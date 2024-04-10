using UnityEngine;

public class PlayerPrefsStringReader : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private string value;
    [ContextMenu("Get")]
    public string Get()
    {
        value = PlayerPrefs.GetString(keyName, value);
        return value;
    }
}
