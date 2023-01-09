using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingScript : MonoBehaviour
{
    public Vector3 result;
    public float rotation;
    public static bool isPlayerHit;



    public void Update()
    {
        result = Vector3.left * 6;
        result = Quaternion.Euler(0, 0, rotation) * result;

        RaycastHit2D hit = Physics2D.Raycast((Vector2)transform.position, result, 5f );

        if (hit != null)
        {
            if (hit == GameObject.FindGameObjectWithTag("Enemy"))
            {
                //Debug.Log("Hit" + hit.collider.name);
                isPlayerHit = true;
            }
            else
                isPlayerHit = false;
        }
    }

    /*private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(this.transform.position, this.transform.position + result);
    }*/
}
