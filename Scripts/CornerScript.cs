using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerScript : MonoBehaviour
{
    private Health health;
    private int oldHealth;
    public GameObject miniExplode;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health.health != oldHealth)
        {
            Instantiate(miniExplode, transform.position + new Vector3(0, 0.5f, 0), transform.rotation);
        }
        oldHealth = health.health;
    }
}
