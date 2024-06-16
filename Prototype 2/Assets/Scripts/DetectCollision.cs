using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // New instance of ScoreSystem
    private ScoreSystem scoreSystem;

    // Destroys objects if they collide
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        scoreSystem.UpdateScore(0.5f);

    }

    // Start is called before the first frame update
    void Start()
    {
        scoreSystem = GameObject.Find("ScoreSystem").GetComponent<ScoreSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
