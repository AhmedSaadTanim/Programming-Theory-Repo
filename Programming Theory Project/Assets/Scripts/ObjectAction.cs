using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//INHERITANCE
public class ObjectAction : ObjectCollision
{

    private GameUIHandler UIHandler;

    private void Start()
    {
        UIHandler = GameObject.Find("UI Handler").GetComponent<GameUIHandler>();
    }

    //POLYMORPHISM & ABSTRACTION
    public override void onObjectEncounter()
    {
        if(gameObject.CompareTag("Health Potion"))
        {
            UpdateHealth(50);
        }
        else if(gameObject.CompareTag("Mana Potion"))
        {
            UpdateMana(50);
        }
        else if(gameObject.CompareTag("Coin"))
        {
            UpdateScore();
        }
    }

    void UpdateHealth(int value)
    {
        UIHandler.ChangeHealthText(value);
    }
    void UpdateMana(int value)
    {
        UIHandler.ChangeManaText(value);
    }
    void UpdateScore()
    {
        UIHandler.ChangeScoreText();
    }
}
