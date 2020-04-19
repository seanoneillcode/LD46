using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public GameObject deadObject;




    public void LoseHealth(int amount)
    {
        this.health -= amount;
        if (this.health <= 0)
        {
            Instantiate(deadObject, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
