using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BossFightMovement : MonoBehaviour
{
    public Animator animator;
    public Scene scene;

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
        movement.y = joystick.Vertical;

    }
    private void FixedUpdate()
    {
        if (movement != Vector2.zero)
        {
            animator.SetFloat("Speed", 1);
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }

    }

}




