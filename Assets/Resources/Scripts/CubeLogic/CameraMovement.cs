using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Vector3 offset = new Vector3(0f, 2f, -10f); // Camera offset from the player
    private Transform playerPos;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

	private void LateUpdate()
	{
		if (playerPos != null)
		{
			Vector3 pos = playerPos.position + offset;
			// Smooth moving
			transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * 5f);
		}
	}
}
