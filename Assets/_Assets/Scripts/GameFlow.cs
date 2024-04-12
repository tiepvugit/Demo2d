using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{
    [SerializeField] private HealthComponent player1;
    [SerializeField] private HealthComponent player2;
    [SerializeField] private GameObject endGameCanvas;
    [SerializeField] private Text messageText;
    private bool isPlaying = false;

    private void Start()
    {
        isPlaying = true;
    }
    private void Update()
    {
        if (!isPlaying)
            return;
        if (player1.IsDead || player2.IsDead)
        {
            isPlaying = false;
            Debug.Log("End Game");
            var winner = player1.IsDead ? player2 : player1;
            EndGame(winner);
        }

    }

    private void EndGame(HealthComponent winner)
    {
        endGameCanvas.SetActive(true);
        messageText.text = $"{winner.name} Win";
    }
}
