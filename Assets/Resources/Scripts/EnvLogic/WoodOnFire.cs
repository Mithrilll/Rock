using UnityEngine;
using Assets.Resources.Scripts.CubeLogic;


public class WoodOnFire : MonoBehaviour
{
    private float fireTime = 2.0f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            // Player player = GameObject.FindWithTag("Player");
            // if (player.FieryState) {
            //     Debug.Log("Wood On Fire");
            // }

        }
    }

    void PlatformOnFire()
    {
        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject, 0.1f);
    }
}
