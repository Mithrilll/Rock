using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Resources.Scripts.CubeLogic;

public class AirGenerator : MonoBehaviour
{
    public float jumpForce = 10f;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerJump playerJumpController = collision.gameObject.GetComponent<PlayerJump>();
            playerJumpController.ApplyJumpBoost(jumpForce);
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerJump playerJumpController = collision.gameObject.GetComponent<PlayerJump>();
            playerJumpController.ResetJumpBoost();
        }
    }
}
