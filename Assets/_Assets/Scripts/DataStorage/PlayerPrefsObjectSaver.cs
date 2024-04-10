using UnityEngine;

public class PlayerPrefsObjectSaver<T> : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private T value;

    protected void SaveData()
    {
        PlayerPrefs.SetString(keyName, JsonUtility.ToJson(value));
    }
}
