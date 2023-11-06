using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private float speed;

    private bool direction;
    private Transform previousPosition;
    private Transform nextPosition;

    private float elapsedTime;
    private float timeToNextPosition;

    private void Awake()
    {
        pointA.SetParent(null);
        pointB.SetParent(null);
    }

    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
        direction = true;
        MoveToNextPoint(direction);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        elapsedTime += Time.deltaTime;

        float elapsedPercentage = elapsedTime / timeToNextPosition;

        transform.position = Vector3.Lerp(previousPosition.position, nextPosition.position, elapsedPercentage);

        if (elapsedPercentage >= 1)
        {
            direction = !direction;
            MoveToNextPoint(direction);
        }
    }

    private void MoveToNextPoint(bool direction)
    {
        if (direction)
        {
            previousPosition = pointA;
            nextPosition = pointB;
        }
        else
        {
            previousPosition = pointB;
            nextPosition = pointA;
        }

        elapsedTime = 0;

        float distanceToTarget= Vector3.Distance(previousPosition.position, nextPosition.position);
        timeToNextPosition = distanceToTarget / speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.transform.SetParent(transform);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.transform.SetParent(null);
    }

}
