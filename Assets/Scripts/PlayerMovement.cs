using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;

    Vector2 movementVector;

    void Start()
    {
        if (moveSpeed == null)
            moveSpeed = 5.0f;

        if (rb == null)
            rb = GetComponent<Rigidbody2D>();

        if (animator == null)
            animator = GetComponent<Animator>();
    }


    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movementVector.x);
        animator.SetFloat("Vertical", movementVector.y);
        animator.SetFloat("Speed", movementVector.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movementVector * moveSpeed * Time.fixedDeltaTime);
    }
}
