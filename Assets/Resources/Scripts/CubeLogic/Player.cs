using Assets.Resources.Scripts.CubeLogic.CubeStates;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Allowable cube states
    CubeState currentState;
    FieryState fieryState;
    LiquidState liquidState;
    StandardState standardState;
    MetalState metalState;
    /// <summary>
    /// Player's current sprite
    /// </summary>
    SpriteRenderer spriteRenderer;

    void Start()
    {
        // Initial states
        standardState = new StandardState(Resources.Load<Sprite>("Sprites/Cube/cube_main"));
        fieryState = new FieryState(Resources.Load<Sprite>("Sprites/Cube/cube_fire"));
        liquidState = new LiquidState(Resources.Load<Sprite>("Sprites/Cube/cube_water"));
        metalState = new MetalState(Resources.Load<Sprite>("Sprites/Cube/cube_metal"));
        spriteRenderer = GetComponent<SpriteRenderer>();

        ChangeState(standardState);
    }

	private void FixedUpdate()
	{
		#region ChangingState
		if (Input.GetKey(KeyCode.Alpha1))
        {
            ChangeState(standardState);
            return;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            ChangeState (fieryState);
            return;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            ChangeState(liquidState); 
            return;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            ChangeState(metalState);
            return;
        }
		#endregion
	}

	private void ChangeState(CubeState state)
	{
        if (currentState == state) return;
		currentState = state;
		spriteRenderer.sprite = state.cubeSprite;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        // if successful
        if (collision.TryGetComponent(out Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials.Material material))
        {
		    currentState.Accept(material);
        }
	}

    public void ExplodeItself ()
    {
        // animation of death 
    }

    public void MoveTo (Transform newPosition)
    {
        this.transform.position = newPosition.position;
    }
}
