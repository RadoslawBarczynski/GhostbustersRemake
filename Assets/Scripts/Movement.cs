using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Animator animator;
    public LineRenderer lineRenderer;
    public Scene scene;

    public static bool isAttacking = false;
    public AttackingScript attackingScript;


    public float moveSpeed = 5f;
    public Joystick joystick;

    public Rigidbody2D rb;

    Vector2 movement;

    private void Start()
    {
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = joystick.Horizontal;
        if (isAttacking == true)
        {
                animator.SetFloat("Attack", 1);
                attackingScript.enabled = true;
                lineRenderer.enabled = true;
        }
        else if (isAttacking == false)
        {            
                animator.SetFloat("Attack", 0);
                attackingScript.enabled = false;
                lineRenderer.enabled = false;
        }

    }
        private void FixedUpdate()
    {
        if(movement != Vector2.zero)
        {
            animator.SetFloat("Speed", 1);
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }

    }

    public void Attack()
    {
        if (isAttacking == true)
            isAttacking = false;
        else
            isAttacking = true;
    }
}




