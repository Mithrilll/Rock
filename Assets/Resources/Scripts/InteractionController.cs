using UnityEngine;

public class InteractionController : MonoBehaviour
{
	public static InteractionController instance;
	private Player player;

	private void Awake()
	{
		instance = this;
	}

	private void Start()
	{
		player = GetComponent<Player>();
	}

	// Logic goes here:

	public void MovePlayerTo(Transform position)
	{
		player.transform.position = position.position;
	}
}
