using System;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
	private static CheckpointController _instance;
	private Transform _currentActiveCheckpoint;

	private void Awake()
	{
		_instance = this;
	}

	/// Logic:
	
	public void UpdateCheckpoint(Checkpoint checkpoint)
	{
		// TODO: initial checkpoint
		_currentActiveCheckpoint = checkpoint.transform;
	}

	public void LoadGameFromLastCheckpoint()
	{
		// TODO: Player get the new feature but dies, the feature(e.g. item) has been saved?

		// Pause()
		// DarkScreenIsRemoving()
		throw new NotImplementedException();
	}
}
