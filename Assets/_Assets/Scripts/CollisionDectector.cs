using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDectector : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger!!!!!!!!!!!!!!");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision!!!!!!!!!!!!!!");
    }
}
