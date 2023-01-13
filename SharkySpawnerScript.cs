using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkySpawnerScript : MonoBehaviour
{
    public GameObject Sharky;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        spawnSharky();
    }

    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnSharky();
            timer = 0;
        }

    }

    void spawnSharky()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        Instantiate(Sharky, new Vector3 (transform.position.x, Random.Range (highestPoint, lowestPoint), 0), transform.rotation);
    }
}
