using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.LoseHealth(1);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.LoseHealth(1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.LoseHealth(1);
        }
    }

}
