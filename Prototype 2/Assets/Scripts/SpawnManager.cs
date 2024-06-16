using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    // Position variables
    private float spawnRangeX = 20;
    private float spawnPosZ = 34;

    // Spawn variables
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    public GameObject[] animalPrefabs;

    // Game state variables
    private bool gameActive = true;
    public TextMeshProUGUI gameOverText;

    // Function in order to spawn animals randomly
    void spawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        if (gameActive)
        {
            Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ), animalPrefabs[animalIndex].transform.rotation);
        }
    }


    // Function to stop spawning
    public void StopSpawning()
    {
        gameActive = false;
        CancelInvoke("spawnRandomAnimal");
        ShowGameOverText();
    }

    // Displays game over
    private void ShowGameOverText()
    {
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Spawns the animals
        InvokeRepeating("spawnRandomAnimal", startDelay, spawnInterval);

        // Ensure game over text is hidden at start
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
