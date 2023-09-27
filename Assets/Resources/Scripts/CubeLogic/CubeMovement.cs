using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float _rollSpeed = 3;
    private Rigidbody2D _rb;
    private bool _inMovement;

    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _inMovement = false;
    }

    private void Update()
    {
        if (_inMovement) return;

        if (Input.GetKey(KeyCode.D))
        {
            MakeMovement(Vector3.right);
            return;
        }
        if (Input.GetKey(KeyCode.A))
        {
            MakeMovement(Vector3.left);
            return;
        }
    }

        private void MakeMovement(Vector3 direction)
    {
		var anchor = transform.position + (direction + Vector3.down) * 0.5f;
		var rotationAxis = Vector3.Cross(Vector3.up, direction);    // Z axis
		StartCoroutine(Roll(anchor, rotationAxis));
	}

	private IEnumerator Roll(Vector3 anchor, Vector3 axis)
    {
        _inMovement = true;

        for (int i = 0; i < (90 / _rollSpeed); i++)
        {
            transform.RotateAround(anchor, axis, _rollSpeed);
            yield return new WaitForSeconds(0.01f);
        }

        _inMovement = false;
    }
}
