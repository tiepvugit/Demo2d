using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField] private HealthComponent health;
    [SerializeField] private Image healBarImage;

    private void Update()
    {
        healBarImage.fillAmount = 1f * health.Health / health.MaxHealth;
    }
}
