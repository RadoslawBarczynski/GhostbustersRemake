using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuKeysManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textfield;
    [SerializeField]
    private GameObject panelZero;
    [SerializeField]
    private GameObject panelOne;
    [SerializeField]
    private GameObject panelTwo;
    [SerializeField]
    private GameObject panelThree;
    [SerializeField]
    private GameObject nextButton;
    //public GameObject floatingText;

    void Update()
    {
       if(GameManager.isGameStarted == true)
        {
            panelZero.SetActive(false);
            panelOne.SetActive(false);
            panelTwo.SetActive(false);
            panelThree.SetActive(true);
        }
       if(panelTwo.activeSelf == true && (GameManager.isTextEnded == true || GameManager.VehicleType > 0))
        {
            textfield.enabled = true;
            textfield.text = "$" + GameManager.money.ToString();
        }
    }

    public void ChangePanelZero()
    {
        panelZero.SetActive(false);
        panelOne.SetActive(true);
    }
    public void ChangePanel()
    {
        panelOne.SetActive(false);
        panelTwo.SetActive(true);
        GameManager.isTextEnded = false;
    }

    public void ChangePanel2()
    {
        panelTwo.SetActive(false);
        panelThree.SetActive(true);
    }

    public void SelectVehicle(int value)
    {
        if(value == 1 && GameManager.money >= 2000)
        {
            GameManager.money -= 2000;
            GameManager.isTextEnded = false;
            GameManager.VehicleType = 1;
            GameManager.maxCrewMembers = 2;
            GameManager.crewMembers = GameManager.maxCrewMembers;
            nextButton.SetActive(true);
        }
        else if(value == 2 && GameManager.money >= 4800)
        {
            GameManager.money -= 4800;
            GameManager.isTextEnded = false;
            GameManager.VehicleType = 2;
            GameManager.maxCrewMembers = 3;
            GameManager.crewMembers = GameManager.maxCrewMembers;
            nextButton.SetActive(true);
        }
        else if (value == 3 && GameManager.money >= 6000)
        {
            GameManager.money -= 6000;
            GameManager.isTextEnded = false;
            GameManager.VehicleType = 3;
            GameManager.maxCrewMembers = 4;
            GameManager.crewMembers = GameManager.maxCrewMembers;
            nextButton.SetActive(true);
        }
        else if (value == 4 && GameManager.money >= 15000)
        {
            GameManager.money -= 15000;
            GameManager.isTextEnded = false;
            GameManager.VehicleType = 4;
            GameManager.maxCrewMembers = 5;
            GameManager.crewMembers = GameManager.maxCrewMembers;
            nextButton.SetActive(true);
        }
        else
        {
            Debug.Log("Not Enough Money");
            //var newPopUp = Instantiate(floatingText, transform.position, Quaternion.identity);
            //newPopUp.transform.SetParent(gameObject.transform);
        }

        
    }

 
}
