using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour
{
    private Vector3 dir;
    public float speed;

    private float attackTimer;
    public float attackTimeTotal;
    public float buildingAttackTimeTotal;

    private Health currentVictim;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        dir = GetRandomDirection();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (attackTimer >= 0)
        {
            attackTimer -= Time.deltaTime;
            dir = Vector3.zero;
            animator.SetBool("attack", true);
        }
        if (attackTimer < 0)
        {
            if (dir.Equals(Vector3.zero))
            {
                dir = GetRandomDirection();
            }
            animator.SetBool("attack", false);
            if (currentVictim != null)
            {
                currentVictim.LoseHealth(1);
                attackTimer = attackTimeTotal;
                if (currentVictim.GetComponent<BuildingDamage>() != null)
                {
                    attackTimer = buildingAttackTimeTotal;
                }
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter(Collision collision)
    {
        AlienController otherAlien = collision.gameObject.GetComponent<AlienController>();
        Health health = collision.gameObject.GetComponent<Health>();

        
        if (otherAlien == null && health != null && health.health > 0)
        {
            attackTimer = attackTimeTotal;
            if (health.GetComponent<BuildingDamage>() != null)
            {
                attackTimer = buildingAttackTimeTotal;
            }
            currentVictim = health;
        } else
        {
            currentVictim = null;
            
        }
        dir = GetRandomDirection();
    }

    void OnCollisionExit(Collision collision)
    {
        currentVictim = null;
    }


    private Vector3 GetRandomDirection()
    {
        return new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
    }
}
