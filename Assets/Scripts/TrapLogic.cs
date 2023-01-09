using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapLogic : MonoBehaviour
{
    public Vector3 result;
    public float rotation;
    public GhostAi ghost;
    [SerializeField]
    private LineRenderer lineRenderer;



    public void Update()
    {
        result = Vector3.up * 6;

        RaycastHit2D hit = Physics2D.Raycast((Vector2)transform.position, result, 5f);

        if (hit != null)
        {
            if (hit == GameObject.FindGameObjectWithTag("Enemy") && AttackingScript.isPlayerHit == true)
            {
                //Debug.Log("PlayerHit!");
                lineRenderer.enabled = true;
                ghost.GhostDeath();
            }
            else if (hit == GameObject.FindGameObjectWithTag("Enemy"))
            {
                //Debug.Log("Hit" + hit.collider.name);
            }
        }
    }

    /*private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(this.transform.position, this.transform.position + result);
    }*/
}
