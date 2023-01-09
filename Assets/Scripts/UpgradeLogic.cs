using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeLogic : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textfield;
    [SerializeField]
    private TextMeshProUGUI TrapsAmounttxt;
    [SerializeField]
    private TextMeshProUGUI MembersTxt;
    [SerializeField]
    private TextMeshProUGUI CostMembersTxt;
    private int result;

    [SerializeField]
    private Button HealMembers;
    [SerializeField]
    private Button VacumButton;
    [SerializeField]
    private Button trapsButton;
    [SerializeField]
    private Button ghostBaitButton;
    [SerializeField]
    private Button pkDetectorButton;
    [SerializeField]
    private Button marshmallowButton;
    [SerializeField]
    private Button imageIntensifierButton;

    void Update()
    {
        if (GameManager.maxCrewMembers > GameManager.crewMembers)
        {
            HealMembers.interactable = true;
            CalculateCostMembers();
            CostMembersTxt.text = "$" + result;
        }
        MembersTxt.text = "MEMBERS: " + GameManager.crewMembers + "/" + GameManager.maxCrewMembers;
        textfield.text = "$" + GameManager.money.ToString();
        TrapsAmounttxt.text = GameManager.trapsAmount.ToString() + "/" + GameManager.maxTrapsAmount.ToString();
        ButtonSetInteractable();
    }

    private void CalculateCostMembers()
    {
        int temp = 0;
        temp = GameManager.maxCrewMembers - GameManager.crewMembers;
        result = 500 * temp;
    }
    public void SelectUpgrade(int value)
    {
        if(value == 1 && GameManager.money >= 1300 && GameManager.trapsAmount > 0)
        {
            GameManager.money -= 1300;
            GameManager.ghostVacum = true;
        }
        else if(value == 2 && GameManager.money >= 500)
        {
            GameManager.money -= 500;
            GameManager.trapsAmount++;
        }
        else if (value == 3 && GameManager.money >= 500 && GameManager.trapsAmount > 0)
        {
            GameManager.money -= 500;
            GameManager.ghostBait = true;
        }
        else if (value == 4 && GameManager.money >= 500 && GameManager.trapsAmount > 0)
        {
            GameManager.money -= 500;
            GameManager.pkDetector = true;
        }
        else if (value == 5 && GameManager.money >= 1500 && GameManager.trapsAmount > 0)
        {
            GameManager.money -= 1500;
            GameManager.marshmallowDetector = true;
            GameManager.numberToBossfight -= 4;
        }
        else if (value == 6 && GameManager.money >= 500 && GameManager.trapsAmount > 0)
        {
            GameManager.money -= 500;
            GameManager.imageIntensifier = true;
        }

    }

    private void ButtonSetInteractable()
    {
        if (GameManager.ghostVacum == true || GameManager.trapsAmount < 1 || GameManager.money < 500)
            VacumButton.interactable = false;
        else
            VacumButton.interactable = true;
        if (GameManager.ghostBait == true || GameManager.trapsAmount < 1 || GameManager.money < 500)
            ghostBaitButton.interactable = false;
        else
            ghostBaitButton.interactable = true;
        if (GameManager.pkDetector == true || GameManager.trapsAmount < 1 || GameManager.money < 500)
            pkDetectorButton.interactable = false;
        else
            pkDetectorButton.interactable = true;
        if (GameManager.marshmallowDetector == true || GameManager.trapsAmount < 1 || GameManager.money < 500)
            marshmallowButton.interactable = false;
        else
            marshmallowButton.interactable = true;
        if (GameManager.imageIntensifier == true || GameManager.trapsAmount < 1 || GameManager.money < 500)
            imageIntensifierButton.interactable = false;
        else
            imageIntensifierButton.interactable = true;
        if (GameManager.money < 500 || GameManager.trapsAmount == GameManager.maxTrapsAmount)
            trapsButton.interactable = false;
        else
            trapsButton.interactable = true;
    }
}
