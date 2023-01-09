using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyLevelSelection : MonoBehaviour
{
    [SerializeField]
    private Button buttonEasy;
    [SerializeField]
    private Button buttonMedium;
    [SerializeField]
    private Button buttonHard;
    [SerializeField]
    private Button nextButton;
    public void DifficultySelection(int value)
    {
        if(value == 1) //EASY
        {
            GameManager.money = 6000;
            GameManager.maxTrapsAmount = 5;
            GameManager.numberToAttack = 3;
            GameManager.cooldown = 8f;
            GameManager.numberToBossfight = 6;
            GameManager.bossTimeAnimation = 2.5f;
        }
        else if(value == 2) //MEDIUM
        {
            GameManager.money = 4000;
            GameManager.maxTrapsAmount = 3;
            GameManager.numberToAttack = 5;
            GameManager.cooldown = 6f;
            GameManager.numberToBossfight = 8;
            GameManager.bossTimeAnimation = 1.5f;
        }
        else if(value == 3) //HARD
        {
            GameManager.money = 3000;
            GameManager.maxTrapsAmount = 1;
            GameManager.numberToAttack = 7;
            GameManager.cooldown = 4f;
            GameManager.numberToBossfight = 12;
            GameManager.bossTimeAnimation = 0.8f;
        }
        HideAllButtons();
    }

    private void HideAllButtons()
    {
        buttonEasy.interactable = false;
        buttonMedium.interactable = false;
        buttonHard.interactable = false;
        nextButton.interactable = true;
    }
}
