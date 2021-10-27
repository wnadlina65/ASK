using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject ansABackBlue; //Blue is waiting
    public GameObject ansABackGreen; //Green is correct
    public GameObject ansABackRed; //Red is wrong

    public GameObject ansBBackBlue; //Blue is waiting
    public GameObject ansBBackGreen; //Green is correct
    public GameObject ansBBackRed; //Red is wrong

    public GameObject answerA;
    public GameObject answerB;

    //method for answer A button
    public void AnswerA()
    {
        if(QuestionGenerate.actualAnswer == "A")
        {
            ansABackGreen.SetActive(true);
            ansABackBlue.SetActive(false);
        }
        else
        {
            ansABackRed.SetActive(true);
            ansABackBlue.SetActive(false);
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
    }

    //method for answer B button
    public void AnswerB()
    {
        if (QuestionGenerate.actualAnswer == "B")
        {
            ansBBackGreen.SetActive(true);
            ansBBackBlue.SetActive(false);
        }
        else
        {
            ansBBackRed.SetActive(true);
            ansBBackBlue.SetActive(false);
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
    }
}
