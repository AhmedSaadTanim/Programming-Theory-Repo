using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText, healthText, manaText;
    int coinCounter = 0;
    int playerHealth = 10;
    int playerMana = 0;

    // Start is called before the first frame update
    public void ChangeScoreText()
    {
        coinCounter++;
        scoreText.text = "Coins: " + coinCounter;
    }

    public void ChangeHealthText(int value)
    {
        playerHealth += value;
        healthText.text = "Health: " + playerHealth;
    }

    public void ChangeManaText(int value)
    {
        playerMana += value;
        manaText.text = "Mana: " + playerMana;
    }
}
