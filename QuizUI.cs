using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private QuizManager quizManager;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private Text questionText, timerText;//, scoreText, timerText, currentScoreText, highestScoreText;
    [SerializeField] private List<Image> lifeImageList;
    [SerializeField] private GameObject gameOverPanel, mainMenuPanel, gameMenuPanel;
    [SerializeField] private Image questionImage;
    [SerializeField] private List<Button> options, uiButtons;
    [SerializeField] private Color correctCol, wrongCol, normalCol;

    private Question question;
    private bool answered;

    //public Text ScoreText { get { return scoreText; } }

    public Text TimerText { get { return timerText; } }

    //public Text CurrentScoreText { get { return currentScoreText; } }

    //public Text HighScoreText { get { return highestScoreText; } }

    public GameObject GameOverPanel { get { return gameOverPanel; } }

   
    private void Awake()
    {
        for(int i = 0; i < options.Count; i++)
        {
            Button localBtn = options[i];
            localBtn.onClick.AddListener(() => OnClick(localBtn));
        }

        for(int i = 0; i < uiButtons.Count; i++)
        {
            Button localBtn = uiButtons[i];
            localBtn.onClick.AddListener(() => OnClick(localBtn));
        }
    }

    public void SetQuestion(Question question)
    {
        this.question = question;

        switch(question.qt)
        {
            case QuestionType.TEXT:

                questionImage.transform.parent.gameObject.SetActive(false);
                //questionImage.sprite = question.questionImg;
                break;

            case QuestionType.IMAGE:

                ImageHolder();
                questionImage.transform.gameObject.SetActive(true);
                questionImage.sprite = question.questionImg;
                break;
        }

        questionText.text = question.questionInfo;
        List<string> answerList = ShuffleList.ShuffleListItems<string>(question.options);

        for(int i = 0; i < options.Count; i++)
        {
            options[i].GetComponentInChildren<Text>().text = answerList[i];
            options[i].name = answerList[i];
            options[i].image.color = normalCol;
        }

        answered = false;
    }

    public void ImageHolder()
    {
        questionImage.transform.parent.gameObject.SetActive(true);
        questionImage.transform.gameObject.SetActive(false);
    }

    private void OnClick(Button btn)
    {
        if(quizManager.GameStatus == GameStatus.Playing)
        {
            if(!answered)
            {
                answered = true;
                bool val = quizManager.Answer(btn.name);

                if(val)
                {
                    btn.image.color = correctCol;
                }
                else
                {
                    btn.image.color = wrongCol;
                }
            }
        }

        switch(btn.name)
        {
            case "Algoritma":
                quizManager.StartGame(0);
                mainMenuPanel.SetActive(false);
                gameMenuPanel.SetActive(true);
                break;
            case "KodArahan":
                quizManager.StartGame(1);
                mainMenuPanel.SetActive(false);
                gameMenuPanel.SetActive(true);
                break;
        }
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReduceLife(int index)
    {
        lifeImageList[index].color = wrongCol;
    }
}
