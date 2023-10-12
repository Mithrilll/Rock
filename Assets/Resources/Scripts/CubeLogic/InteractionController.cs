using UnityEngine;

public class InteractionController : MonoBehaviour
{
    private static InteractionController _instance;
	private UIController _UIcontroller;
	private CheckpointController _checkpointController;

    public InteractionController Instance()
    {
        return _instance;
    }

	// Logic goes here:

    // Awake method is called before Start method
	private void Awake()
	{
		_instance = this;
	}

	private void Start()
	{
		var objects = FindObjectsOfType<Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials.Material>();
		foreach (var obj in objects)
		{
			obj.OnPlayerDeath += HandlePlayerDeath;
		}
		_UIcontroller = GetComponent<UIController>();
		_checkpointController = GetComponent<CheckpointController>().Instance;
	}

	/// <summary>
	/// This method will be called when any object in the objects call Action OnPlayerDeath
	/// </summary>
	private void HandlePlayerDeath()
    {
		// _player.ExplodeItself();
		_UIcontroller.BlurScreen();
		// _player.MoveTo(_checkpointController.CurrentActiveCheckpoint);
		_UIcontroller.UnblurScreen();
	}
}
