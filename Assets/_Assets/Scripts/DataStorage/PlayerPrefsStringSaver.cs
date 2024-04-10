using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsStringSaver : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private string value;

    [ContextMenu("Save")]
    public void Save()
    {
        PlayerPrefs.SetString(keyName, value);
    }
}
