using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDetectionInRange : MonoBehaviour
{
    public GameObject target;
    //public GameObject BuildingPosition;
    [SerializeField]
    private Button button;
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private GameObject BaseBuilding;
    [SerializeField]
    private Button BaseButton;
    [SerializeField]
    private Button BossFightButton;
    [SerializeField]
    private GameObject ZuulBuilding;
    private GameObject EnteredBuilding;

    public float maxRange = 1;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        gameManager = GameManager.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        button.interactable = false;
        foreach (GameObject building in BuildingsInfection.infectedBuildings)
        {
            if (Vector3.Distance(target.transform.position, building.transform.position) < maxRange && CityLogic.isMoreTraps == true)
            {
                button.interactable = true;
                EnteredBuilding = building;
            }
        }

        if (Vector3.Distance(target.transform.position, BaseBuilding.transform.position) < maxRange)
        {
            BaseButton.interactable = true;
        }
        else
        {
            BaseButton.interactable = false;
        }
        if (Vector3.Distance(target.transform.position, ZuulBuilding.transform.position) < maxRange && ZuulBuilding.activeSelf == true)
                BossFightButton.interactable = true;
        else
            BossFightButton.interactable = false;

    }

    public void insertedValue()
    {
        SelectedBuilding(EnteredBuilding);
        SceneManager.LoadScene("GhostFightScene");
    }

    public GameObject SelectedBuilding(GameObject buildingThis)
    {
        Debug.Log(buildingThis.name);
        GameManager.infectedBuildingsNames.Remove(buildingThis.name);
        BuildingsInfection.infectedBuildings.Remove(buildingThis);
        buildingThis.SetActive(false);
        GameManager.ActualInfectedBuildings--;
        return buildingThis;
    }
}
