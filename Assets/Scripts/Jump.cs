using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D playerRb;
    [SerializeField] float jumpForce, fallForce, jumpLimit, jumpTime, jumpCount;
    [SerializeField] bool isGrounded, isJumping;
    Vector2 gravity;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        gravity = new Vector2 (0, -Physics2D.gravity.y);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
            isJumping = true;
            jumpCount = 0;
        }

        if (playerRb.velocity.y < 0)
        {
            playerRb.velocity -= gravity * fallForce * Time.deltaTime;
        }
        
        if (playerRb.velocity.y > 0 && isJumping)
        {
            jumpCount += Time.deltaTime;
            if (jumpCount > jumpTime)
            {
                isJumping = false;
            }

            playerRb.velocity += gravity * jumpLimit * Time.deltaTime;
        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGrounded = false;
    }
}
