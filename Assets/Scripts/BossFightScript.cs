using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BossFightScript : MonoBehaviour
{
    public Animator animator;

    [SerializeField]
    private TextMeshProUGUI MembersLeftTxt;

    [SerializeField]
    private float timeBetweenJumps = GameManager.bossTimeAnimation;
    private bool isJumpedOnce = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenJumps > 0)
            timeBetweenJumps -= Time.deltaTime;
        else if(isJumpedOnce == true)
        {
            animator.SetBool("JumpTwo", true);
            timeBetweenJumps = GameManager.bossTimeAnimation;
            isJumpedOnce = false;
        }
        else if (animator.GetBool("JumpTwo") == true && isJumpedOnce == false)
        {
            animator.SetBool("JumpTwo", false);
            animator.SetBool("JumpOne", false);
        }
        else
        {
            animator.SetBool("JumpOne", true);
            timeBetweenJumps = GameManager.bossTimeAnimation;
            isJumpedOnce = true;
        }

        MembersLeftTxt.text = "Members Left: " + GameManager.crewMembers;
    }
}
