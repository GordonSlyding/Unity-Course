using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{

    private float score;
    public TextMeshProUGUI scoreText;

    // Updates the score
    public void UpdateScore(float scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = "Score: " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
