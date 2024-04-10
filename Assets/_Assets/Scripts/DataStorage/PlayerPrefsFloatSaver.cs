using UnityEngine;

public class PlayerPrefsFloatSaver : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private float value;

    [ContextMenu("Save")]
    public void Save()
    {
        PlayerPrefs.SetFloat(keyName, value);
    }
}
