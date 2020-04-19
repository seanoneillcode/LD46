using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform.position, Vector3.up);
        Vector3 eulerAngles = transform.eulerAngles;
        transform.eulerAngles = eulerAngles;
        transform.rotation = transform.rotation * Quaternion.Euler(0, 180, 0);
    }
}
