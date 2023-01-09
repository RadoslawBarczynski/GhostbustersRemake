using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    public void LoadUpgradeScene()
    {
        SceneManager.LoadScene("UpgradeMenu");
    }

    public void LoadCityScene()
    {
        GameManager.isGameStarted = true;
        SceneManager.LoadScene("CityScene");
    }

    public void LoadFightScene()
    {
        SceneManager.LoadScene("GhostFightScene");
    }
    public void LoadBossFightScene()
    {
        SceneManager.LoadScene("BossFightScene");
    }
}
