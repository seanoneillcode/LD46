using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSlow : MonoBehaviour
{
    public float rotateAmount;
    private float amount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotateAmount, 0), Space.World);
    }
}
