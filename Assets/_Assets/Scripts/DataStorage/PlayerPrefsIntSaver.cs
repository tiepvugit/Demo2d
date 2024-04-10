using UnityEngine;

public class PlayerPrefsIntSaver : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private int value;

    [ContextMenu("Save")]
    public void Save()
    {
        PlayerPrefs.SetInt(keyName, value);
    }
}