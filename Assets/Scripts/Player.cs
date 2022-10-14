using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Movement
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        if(x != 0)
        {
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", x);
        }
        if(y != 0)
        {
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("Vertical", y);
        }
        if (x != 0 || y != 0)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
        UpdateMotor(new Vector3 (x, y, 0));
    }
}
