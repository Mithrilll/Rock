using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private bool isGrounded = true;
    private bool isJumpBoosted = false;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Check if the player is on the ground
       // isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // Jump only if the player is on the ground
        if (isGrounded && Input.GetKeyDown(KeyCode.Space) && !isJumpBoosted)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
        }
    }


    // air generator jump handler
    public void ApplyJumpBoost(float boostForce)
    {
        _rb.AddForce(new Vector2(0f, boostForce), ForceMode2D.Impulse);
        isJumpBoosted = true;
    }

    public void ResetJumpBoost()
    {
        isJumpBoosted = false;
    }
}
