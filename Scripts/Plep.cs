using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plep : MonoBehaviour
{

    private Vector3 dir;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        dir = GetRandomDirection();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter(Collision collision)
    {
        dir = GetRandomDirection();
    }

    private Vector3 GetRandomDirection()
    {
        return new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
    }
}
