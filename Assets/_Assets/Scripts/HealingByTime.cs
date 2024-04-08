using System;
using System.Collections;
using UnityEngine;

public class HealingByTime : MonoBehaviour
{
    [SerializeField] private HealthComponent targetHealth;
    [SerializeField] private int healAmount;
    [SerializeField] private int delay;
    [SerializeField] private float elapsedTime;
    //private void Update()
    //{
    //    elapsedTime += Time.deltaTime;
    //    if(elapsedTime>= delay)
    //    {
    //        elapsedTime = 0;
    //        Heal();
    //    }
    //}


    //private void Start()
    //{
    //    InvokeRepeating(nameof(Heal),delay, delay);
    //}

    private void Start()
    {
        StartCoroutine(IEHealing());
    }

    private IEnumerator IEHealing()
    {
        yield return new WaitForSeconds(delay);
        Heal();
        yield return StartCoroutine(IEHealing());
    }

    private void Heal()
    {
        targetHealth.Heal(healAmount);
    }
}