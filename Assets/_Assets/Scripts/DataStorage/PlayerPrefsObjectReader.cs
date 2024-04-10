using UnityEngine;

public class PlayerPrefsObjectReader<T> : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private T value;

    public T Value { get => value; set => this.value = value; }

    protected T GetData()
    {
        var data = PlayerPrefs.GetString(keyName, JsonUtility.ToJson(Value));
        Value = JsonUtility.FromJson<T>(data);
        return Value;
    }
}