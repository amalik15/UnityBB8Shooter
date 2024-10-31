using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public Text ScoreText;
    public int maxScore = 5;

    int score;
    void Start()
    {
        score = 0;
        ScoreText.text = "Score: " + score;
    }

    public void AddPoint()
    {
        score++;

        if (score != maxScore)
        {
            ScoreText.text = "Score: " + score;
        }
        else
        {
            SceneManager.LoadScene("win");
        }
    }
}
