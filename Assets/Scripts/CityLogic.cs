using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CityLogic : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI trapsAmountWarning;
    public static bool isMoreTraps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.trapsAmount <= 0)
        {
            trapsAmountWarning.enabled = true;
            trapsAmountWarning.text = "Warning!" + "Buy Traps to HUNT!";
            isMoreTraps = false;
        }
        else
        {
            trapsAmountWarning.enabled = false;
            isMoreTraps = true;
        }
    }
}
