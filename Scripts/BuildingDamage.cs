using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingDamage : MonoBehaviour
{
    public GameObject noDamage;
    public GameObject lightDamage;
    public GameObject heavyDamage;

    private Health health;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health.health == 1)
        {
            noDamage.SetActive(false);
            lightDamage.SetActive(false);
            heavyDamage.SetActive(true);
        }
        if (health.health == 2)
        {
            noDamage.SetActive(false);
            lightDamage.SetActive(true);
            heavyDamage.SetActive(false);
        }
        if (health.health == 3)
        {
            noDamage.SetActive(true);
            lightDamage.SetActive(false);
            heavyDamage.SetActive(false);
        }
    }
}
