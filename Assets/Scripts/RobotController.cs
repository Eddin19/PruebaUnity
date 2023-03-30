using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer sr;

    private int currentAnimation = 1;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentAnimation = 1;
        var velocityY = rb.velocity.y;
        rb.velocity = new Vector2 (0, velocityY);

        if (Input.GetKey("q"))
        {
            currentAnimation = 2;
        }
        if (Input.GetKey("e"))
        {
            currentAnimation = 3;
        }
        if (Input.GetKey("d"))
        {
            currentAnimation = 4;
            rb.velocity = new Vector2(4, velocityY);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.Space))
        {
            currentAnimation = 5;
            rb.velocity = new Vector2(5, velocityY);
        }
        if (Input.GetKey("z"))
        {
            currentAnimation = 6;
            rb.velocity = new Vector2(6, velocityY);
        }
        if (Input.GetKey("v"))
        {
            currentAnimation = 7;
        }
        animator.SetInteger("Estado", currentAnimation);
    }
}
