using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private MoveByKey movingComponent;
    [SerializeField] private CrounchByKey crouchComponent;
    [SerializeField] private JumpByKey jumpingComponent;
    [SerializeField] private HealthComponent healthComponent;
    [SerializeField] private AttackByKey attackComponent;
    [SerializeField] private HealingByTime healingComponent;
    [SerializeField] private List<MonoBehaviour> components;


    private bool isPlaying = false;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        GetReferences();
        DisableComponents();
    }

    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        Debug.Log("Start Game");
        isPlaying = true;
        EnableComponents();
    }

    private void Update()
    {
        if (!isPlaying)
            return;
        if(healthComponent.IsDead)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        isPlaying = false;
        DisableComponents();
    }

    private void GetReferences()
    {
        components = new List<MonoBehaviour>();

        components.Add(movingComponent);
        components.Add(jumpingComponent);
        components.Add(crouchComponent);
        components.Add(healthComponent);
        components.Add(attackComponent);
        components.Add(healingComponent);
    }

    private void DisableComponents()
    {
        Debug.Log("DisableComponents");
        SetActiveComponents(false);
    }

    private void EnableComponents()
    {
        Debug.Log("EnableComponents");
        SetActiveComponents(true);
    }

    private void SetActiveComponents(bool isActive)
    {
        foreach (var component in components)
        {
            component.enabled = isActive;
        }
    }



}
