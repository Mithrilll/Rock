using Assets.Resources.Scripts.CubeLogic.CubeStates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CubeState currentState;
    FieryState fieryState;
    LiquidState liquidState;
    StandardState standardState;
    MetalState metalState;

    void Start()
    {
        fieryState = new FieryState();
        liquidState = new LiquidState();
        standardState = new StandardState();
        metalState = new MetalState();

        currentState = fieryState;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		currentState.Accept(collision.GetComponent<Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials.Material>());
	}
}
