using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<string> infectedBuildingsNames = new List<string>();

    public static long money;
    public static bool isTextEnded;
    public static bool isGameStarted;
    public static int VehicleType;
    public static int BuildingsRescued;
    public static int CityPkValue;
    public static int i = 0;
    public static int daysCounter = 1;
    public static int crewMembers;
    public static int maxCrewMembers;
    public static float bossTimeAnimation;


    //CityVariables
    public static float timeStartValue;
    public static int numberToAttack = 3;
    public static int ActualInfectedBuildings = 0;
    public static float cooldown = 4f;
    public static int numberToBossfight;

    //upgrade variables
    public static int trapsAmount;
    public static int maxTrapsAmount;
    public static bool pkDetector;
    public static bool ghostVacum;
    public static bool marshmallowDetector;
    public static bool imageIntensifier;
    public static bool ghostBait;

}
