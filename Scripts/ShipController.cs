using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed;
    private Vector3 mov;

    public float shootDelay;
    private float shootTimer;

    public GameObject deathRay;

    // Start is called before the first frame update
    void Start()
    {
        mov = new Vector3(1f, 0, -1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (mov * speed * Time.deltaTime);
        if (transform.position.x > 10)
        {
            mov.x = -1;
        }
        if (transform.position.x < 0)
        {
            mov.x = 1;
        }
        if (transform.position.z > 10)
        {
            mov.z = -1;
        }
        if (transform.position.z < 0)
        {
            mov.z = 1;
        }

        shootTimer -= Time.deltaTime;
        if (shootTimer < 0)
        {
            shootTimer = shootDelay;
            deathRay.SetActive(!deathRay.activeSelf);
        }

        if (transform.childCount < 2)
        {
            Destroy(gameObject);
        }
    }
}
