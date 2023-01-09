using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class AutoTypeScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textfield;
    public string texto;
    [SerializeField]
    private string txtFileName;
    [SerializeField]
    private GameObject SkipButton;
    private bool skip = false;
    [SerializeField]
    public List<GameObject> buttonList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //texto = File.ReadAllText("D:/Unity Projekty/GhostbustersRemake/Assets/Scripts/TextFiles/" +txtFileName + ".txt");
        TextSelection();
        StartCoroutine("AutoType");
    }

    private void Update()
    {
        if (GameManager.isTextEnded == true)
        {
            foreach (GameObject Button in buttonList)
            {
                Button.SetActive(true);
            }
            //HideAllButtons();
        }
        else if(GameManager.isTextEnded == false)
        {
            HideAllButtons();
        }
    }

    public void HideSkipButton()
    {
        if (skip == false)
        {
            skip = true;
            SkipButton.SetActive(false);
        }
        else
            SkipButton.SetActive(true);
    }

    public void HideAllButtons()
    {
        foreach (GameObject Button in buttonList)
        {
            Button.SetActive(false);
        }
    }

    IEnumerator AutoType()
    {
        string temp = "";
        string temp2 = texto;
        bool collect = false;
        bool collectvariable = false;
        foreach (char letter in texto.ToCharArray())
        {
            //detect text edit variable
            if (letter == '<' && collect==false)
            {
                collect = true;
                temp += letter;
            }
            else if(collect == true)
            {
                temp += letter;
                if(letter == '>')
                {
                    collect = false;
                    textfield.text += temp;
                    temp = "";
                    yield return new WaitForSeconds(0.05f);
                }
            }
            //Detect player variable in text
            else if(letter == '[' && collectvariable == false)
            {
                collectvariable = true;
            }
            else if(collectvariable == true)
            {
                if(letter == ']')
                {
                    collectvariable = false;
                    temp += GameManager.money.ToString();
                    textfield.text += temp;
                    temp = "";
                    yield return new WaitForSeconds(0.05f);
                }
            }
            else
            {
                textfield.text += letter;
                yield return new WaitForSeconds(0.05f);
            }
            if(skip == true)
            {
                textfield.text = temp2;
                GameManager.isTextEnded = true;
                skip = false;
                break;
            }
        }
        GameManager.isTextEnded = true;
        //i++;
    }

    public void TextSelection()
    {
        texto = "";
        if (GameManager.i == 1)
        {
            texto = "<b>GHOSTBUSTERS VEHICLE SELECTION</b>\n" +
        "1. COMPACT					 $2000\n" +
        "2. 1963 HEARSE				 $4800\n" +
        "3. STATION WAGON			 $6000\n" +
        "4. HIGH-PERFORMANCE			$15000\n" +


        "YOU HAVE\n" +
        "PRESS INFO TO VIEW CAR OPTIONS\n" +
        "PRESS ONE BUTTON TO PURCHASE CAR\n" +
        "WAITING...\n";
        }
        else if(GameManager.i == 0)
        {
            texto = "<b>GHOSTBUSTERS</b>\n"+
"FOR PROFESSIONAL\n"+
    "    PARANORMAL\n"+
       "     INVESTIGATIONS\n"+
            "    AND ELEMINATIONS\n"+
    " DO YOU HAVE PLAYED IN THIS GAME? \n"+
    " IF NOT CLICK ON HELP BUTTON HERE --->\n" + 
    " IN THAT CASE, WELCOME TO YOUR NEW BUSINESS.\n" +
"AS A NEW FRANCHISE OWNER THE BANK WILL\n"+
"ADVANCE YOUR MONEY FOR EQUIPMENT DEPENDENT OD YOUR DIFFICULTY. USE IT WISELY... \n"+
"GOOD LUCK!\n";
            GameManager.i++;
        }

 }
}
