using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconsLogic : MonoBehaviour
{
    [SerializeField]
    private Image VacumImage;
    [SerializeField]
    private Image GhostBaitImage;
    [SerializeField]
    private Image ImageIntesifierImage;
    [SerializeField]
    private Image MarshmallowImage;
    [SerializeField]
    private Image PkDetectorImage;

    // Update is called once per frame
    void Update()
    {
        if(GameManager.ghostVacum == true)
        {
            VacumImage.enabled = true;
        }
        if (GameManager.ghostBait == true)
        {
            GhostBaitImage.enabled = true;
        }
        if (GameManager.marshmallowDetector == true)
        {
            MarshmallowImage.enabled = true;
        }
        if (GameManager.imageIntensifier == true)
        {
            ImageIntesifierImage.enabled = true;
        }
        if (GameManager.pkDetector == true)
        {
            PkDetectorImage.enabled = true;
        }
    }
}
