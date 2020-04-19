using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip tune1;
    public AudioClip tune2;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            if (source.clip.Equals(tune1))
            {
                source.clip = tune2;
            } else
            {
                source.clip = tune1;
            }
            source.Play();
        }
    }
}
