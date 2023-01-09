using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndingScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI EndingTXT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.crewMembers > 0)
        {
            EndingTXT.text = "THE END\n" + "YOU WON";
        }
        else
            EndingTXT.text = "THE END\n" + "YOU LOST";
    }
}
