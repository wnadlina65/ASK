using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayQuesion = false;

    void Update()
    {
        if(displayQuesion == false)
        {
            displayQuesion = true;
            QuestionDisplay.newQuestion = "Berdasarkan algoritma dalam rajah di atas, adakah turutan tersebut betul bagi etika pemakaian yang kemas?";
            QuestionDisplay.newA = "Betul";
            QuestionDisplay.newB = "Salah";
            actualAnswer = "A";
        }
    }
}
