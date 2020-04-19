using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysGround : MonoBehaviour
{
    public GameObject refObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(refObj.transform.position, -Vector3.up, out hit))
        {
            transform.position = hit.point + new Vector3(0, 0.2f, 0);
            //offsetDistance = hit.distance;
            //Debug.DrawLine(transform.position, hit.point, Color.cyan);
        }
    }
}
