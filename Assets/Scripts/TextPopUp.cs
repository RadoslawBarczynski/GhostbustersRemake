using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextPopUp : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textfield;


    private void Awake()
    {
        textfield = transform.GetComponent<TextMeshProUGUI>();
    }

    public void Setup(string textValue)
    {
        textfield.text = textValue;
    }


}
