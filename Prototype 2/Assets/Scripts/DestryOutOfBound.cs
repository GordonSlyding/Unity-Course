using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryOutOfBound : MonoBehaviour
{
    // Define the border of the map
    private float topBorder = 34.4f;
    private float bottomBorder = -0.5f;
    private SpawnManager spawnManager;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {

        // Border and handles game over
        if (transform.position.z >= topBorder)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= bottomBorder)
        {

            Destroy(gameObject);
            spawnManager.StopSpawning();
            Debug.Log("Game Over");
        }

    }
}

