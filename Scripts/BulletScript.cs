using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bulletDeath;


    void OnCollisionEnter(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.LoseHealth(1);
        }
        Instantiate(bulletDeath, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
