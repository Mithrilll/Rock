using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private CheckpointController controller;

	private bool _isActivated;

	private void Start()
	{
		_isActivated = false;
		controller = GetComponent<CheckpointController>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (_isActivated) return;

		controller.UpdateCheckpoint(this);
		_isActivated = true;
	}
}
