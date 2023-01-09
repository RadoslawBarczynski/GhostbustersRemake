using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAi : MonoBehaviour
{
    public float speed = 5;
    public float range = 0.5f;
    private bool ghostcaptured;
    [SerializeField]
    private GameObject Button;

    float startingX;
    int dir = 1;
    // Start is called before the first frame update
    void Start()
    {
        startingX = transform.position.x;
        if (GameManager.ghostBait == true)
            speed = 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime * dir);
        if(transform.position.x < startingX || transform.position.x > startingX + range)
        {
            dir *= -1;
        }
        else if(ghostcaptured == true)
        {
            dir *= 0;
            speed = 0.5f;
            transform.Translate(Vector2.down * speed * Time.deltaTime * range);
        }
    }

    public void GhostDeath()
    {
        ghostcaptured = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Button.SetActive(true);
        GameManager.BuildingsRescued++;
        GameManager.CityPkValue -= 30;
        GameManager.money += 600;
        GameManager.trapsAmount--;
        Debug.Log("GhostDestroyed");
        Destroy(this.gameObject);
    }
}
