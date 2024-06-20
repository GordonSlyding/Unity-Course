using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 100;
    private float spawnInterval;
    private float startDelay = 1.0f;
    


    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int randomBall = UnityEngine.Random.Range(0, ballPrefabs.Length);
        float spawnInterval = UnityEngine.Random.Range(3.0f, 5.0f);


        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[0].transform.rotation);
        // Debug.Log(spawnInterval);
    }



}
