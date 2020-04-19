using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public float jumpForce = 1.0f;
    private bool isJump;
    private Vector3 move;

    public GameObject bulletPrefab;
    private Vector3 lastDir;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastDir = new Vector3(1, 0, 0);
    }

    void Update()
    {
        float moveHorizontal = -Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(1, 0, 1);// Camera.main.transform.forward;
        Vector3 movev = new Vector3(moveVertical * dir.x, 0, moveVertical * dir.z);

        dir = new Vector3(-1, 0, 1);
        Vector3 moveh = new Vector3(moveHorizontal * dir.x, 0, moveHorizontal * dir.z);

        move = moveh + movev;

        if (Input.GetButtonDown("Jump"))
        {
            isJump = true;
        }

        if (!(move.x == 0 && move.z == 0))
        {
            lastDir = move;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            FireBullet();
        }
    }
       

    // Update is called once per frame
    void FixedUpdate()
    {
        
        transform.Translate(move * speed * Time.deltaTime, Space.World);

        if (isJump)
        {
            
            float jf = jumpForce;
            if (rb.velocity.y < -0.1f)
            {
                jf = jf * 1.5f;
            }
            rb.AddForce(new Vector3(0.0f, 1.0f, 0.0f) * jf, ForceMode.Impulse);
            
        }
        isJump = false;
    }

    private void FireBullet()
    {
        GameObject obj = Instantiate(bulletPrefab, transform.position + new Vector3(0, 0f, 0), transform.rotation);
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.transform.Translate(lastDir * 0.3f);
        rb.velocity = lastDir * bulletSpeed;
        obj.transform.rotation = Quaternion.LookRotation(lastDir.normalized, new Vector3(0, 1, 0));
    }
}
