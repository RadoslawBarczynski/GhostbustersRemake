using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsInfection : MonoBehaviour
{
    [SerializeField]
    List<GameObject> gameobjects = new List<GameObject>();
    [SerializeField]
    public static List<GameObject> infectedBuildings = new List<GameObject>();
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private GameObject ZuulBuilding;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.FindObjectOfType<GameManager>();
        GameManager.timeStartValue = GameManager.cooldown;
        infectedBuildings.Clear();
        LoadBuildings();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.ActualInfectedBuildings < GameManager.numberToAttack)
        {
            if (GameManager.timeStartValue > 0)
            {
                GameManager.timeStartValue -= Time.deltaTime;
            }
            else
            {
                InfectRandomBuilding();
                Debug.Log("Building infected!");
                GameManager.timeStartValue = GameManager.cooldown;
                GameManager.ActualInfectedBuildings++;
                GameManager.CityPkValue += 50;
            }
        }
        if (GameManager.BuildingsRescued >= GameManager.numberToBossfight)
        {
            ZuulBuilding.SetActive(true);
        }

    }

   public void InfectRandomBuilding()
    {
        GameObject building = gameobjects[Random.Range(0, gameobjects.Count)];
        while (building.activeSelf)
        {
            building = gameobjects[Random.Range(0, gameobjects.Count)];
        }
        infectedBuildings.Add(building);
        building.SetActive(true);
        GameManager.infectedBuildingsNames.Add(building.name);
    }


    public void LoadBuildings()
    {
        foreach(GameObject buildings in gameobjects)
        {
            if (GameManager.infectedBuildingsNames.Contains(buildings.name))
            {
                buildings.SetActive(true);
                infectedBuildings.Add(buildings);
            }
        }
    }





}
