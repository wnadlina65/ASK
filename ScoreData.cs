using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreData : MonoBehaviour
{
    //[SerializeField] ScoreManager scoreManager;
    [SerializeField] GameObject scoreboardPanel;

    public Text score;
    public Text highScore;

    public void clickScoreboardBtn()
    {
        scoreboardPanel.SetActive(true);
    }

    public void scoreboard()
    {
        PlayerPrefs.SetString("score", score.text);
        PlayerPrefs.SetString("highscore", highScore.text);
        Debug.Log("Score: " + PlayerPrefs.GetString("score")
            + "Highscore: " + PlayerPrefs.GetString("highscore"));
    }

    /*public void BackButton()
    {
        scoreboardPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }*/
}
