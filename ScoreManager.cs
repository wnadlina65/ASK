using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text currentScoreText;
    public Text highScoreText;

    int score = 0;
    int currentScore = 0;
    int highScore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score: " + score.ToString();
        currentScoreText.text = "Current score : " + currentScore.ToString();
        highScoreText.text = "Highscore : " + highScore.ToString();
    }

    public void AddScore()
    {
        score += 10;
        currentScore = score;

        scoreText.text = "Score: " + score.ToString();
        currentScoreText.text = "Current score : " + currentScore.ToString();

        if (highScore < currentScore)
        {
            PlayerPrefs.SetInt("highscore", currentScore);
        }
    }
}
