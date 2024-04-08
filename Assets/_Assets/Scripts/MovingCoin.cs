using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCoin : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rig2D;


    // Start is called before the first frame update
    void Start()
    {
        rig2D.velocity = Vector2.right* 10;
    }

    // Update is called once per frame
    void Update()
    {
        //rig2D.velocity = Vector2.right;

    }
}
