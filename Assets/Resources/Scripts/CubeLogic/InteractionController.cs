using UnityEngine;

public class InteractionController : MonoBehaviour
{
    private static InteractionController _instance;
	private UIController _UIcontroller;
	private CheckpointController _checkpointController;
	private Player _player;




    public InteractionController Instance() { return _instance; }

	// Logic goes here:

    // Awake method is called before Start method
	private void Awake() { _instance = this; }

	private void Start()
	{
		var objects = FindObjectsOfType<Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials.Material>();
		foreach (var obj in objects)
		{
			obj.OnPlayerDeath += HandlePlayerDeath;
		}
		_UIcontroller = FindObjectOfType<UIController>();
		_checkpointController = FindObjectOfType<CheckpointController>();

		_player = FindObjectOfType<Player>();
	}

	/// <summary>
	/// This method will be called when any object in the objects call Action OnPlayerDeath
	/// </summary>
	private void HandlePlayerDeath()
    {
		_player.ExplodeItself();
		_UIcontroller.BlurScreen();
		_player.MoveTo(_checkpointController.CurrentActiveCheckpoint.transform);
		_UIcontroller.UnblurScreen();
	}
}
