using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        bool moveRight = false;
        bool moveLeft = false;
        bool moveUp = false;
        bool moveDown = false;
        bool attack = false;
        bool jump = false;

        if (h > 0)
        {
            moveRight = true;
        }
        if (h < 0)
        {
            moveLeft = true;
        }
        if (v > 0)
        {
            moveUp = true;
        }
        if (v < 0)
        {
            moveDown = true;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            attack = true;
        }
        if (Input.GetButtonDown("Jump") && !moveDown && !moveUp && !moveLeft && !moveRight)
        {
            jump = true;
        }

        animator.SetBool("move-up", moveUp);
        animator.SetBool("move-down", moveDown);
        animator.SetBool("move-left", moveLeft);
        animator.SetBool("move-right", moveRight);
        animator.SetBool("attack", attack);
        animator.SetBool("jump", jump);
    }
}
