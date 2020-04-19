using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip shoot;

    private AudioSource source;
    

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            source.PlayOneShot(jump);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            source.PlayOneShot(shoot);
        }
    }
}
