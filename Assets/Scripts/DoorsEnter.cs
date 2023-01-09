using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorsEnter : MonoBehaviour
{

    [SerializeField]
    private bool setFunction;
    [SerializeField]
    private Transform RespawnPoint;

    private float posX;
    private float posY;
    private float posZ;
    // Start is called before the first frame update

    private void Start()
    {
        posX = RespawnPoint.position.x;
        posY = RespawnPoint.position.y;
        posZ = RespawnPoint.position.z;
    }
    public void Respawn()
    {
        RespawnPoint.transform.position = new Vector3 (posX, posY, posZ);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (setFunction == false)
            SceneManager.LoadScene("Ending");
        else
        {
            GameManager.crewMembers--;
            Debug.Log(GameManager.crewMembers);
            if (GameManager.crewMembers < 1)
                SceneManager.LoadScene("Ending");
            else
                Respawn();
        }
    }
}
