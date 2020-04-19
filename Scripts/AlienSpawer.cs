using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawer : MonoBehaviour
{
    public GameObject alienPrefab;
    public GameObject blobPrefab;

    public float spawnRate;
    public float spawnBlobRate;
    public float spawnRateAcc;
    public float maxRate;
    public float xsize;
    public float zsize;

    private float timer;
    private float blobTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnRate)
        {
            SpawnAlien();
            timer = 0;
            spawnRate -= spawnRateAcc;
            if (spawnRate < maxRate)
            {
                spawnRate = maxRate;
            }
        }

        blobTimer += Time.deltaTime;
        if (blobTimer > spawnBlobRate)
        {
            SpawnBlob();
            blobTimer = 0;
            spawnBlobRate -= spawnRateAcc;
            if (spawnBlobRate < maxRate)
            {
                spawnBlobRate = maxRate;
            }
        }
    }

    private void SpawnAlien()
    {
        Vector3 pos = new Vector3(Random.Range(0f, xsize), 6f, Random.Range(0f, zsize));
        Instantiate(alienPrefab, pos, transform.rotation);
    }

    private void SpawnBlob()
    {
        Vector3 pos = new Vector3(Random.Range(0f, xsize), 6f, Random.Range(0f, zsize));
        Instantiate(blobPrefab, pos, transform.rotation);
    }
}
