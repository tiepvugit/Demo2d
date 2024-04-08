using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DemoButton : MonoBehaviour
{

    [SerializeField] private GameObject player;
    
    public void KillPlayer()
    {
        Debug.Log("Kill Player");
        Destroy(player);
    }
}
