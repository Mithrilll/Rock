using UnityEngine;

public class PlatformBreaker : MonoBehaviour
{
    public float breakHeight = 10f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 playerPosition = GameObject.FindWithTag("Player").transform.position;
            if (playerPosition.y > transform.position.y - breakHeight)
            {
                BreakPlatform();
            }
        }
    }

    void BreakPlatform()
    {
        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject, 0.1f);
    }
}
