using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    Text scoreText;
    int score;
    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
        ChangeScore(0);
    }

    public void ChangeScore(int amount){
        score += amount;
        scoreText.text = "Score: " + score;
    }
}
