using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TopBarScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI money;
    [SerializeField]
    private TextMeshProUGUI buildingRescued;
    [SerializeField]
    private TextMeshProUGUI pkValue;

    void Update()
    {
        money.text = "$" + GameManager.money.ToString();
        if(GameManager.pkDetector == true)
        {
            pkValue.enabled = true;
        }
        pkValue.text = "City PK: " + GameManager.CityPkValue.ToString();
        buildingRescued.text = "Ghost defeated: " + GameManager.BuildingsRescued.ToString();
    }
}
