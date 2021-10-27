using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject ansA;
    public GameObject ansB;
    public static string newQuestion;
    public static string newA;
    public static string newB;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PushTextOnScreen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<Text>().text = newQuestion;
        ansA.GetComponent<Text>().text = newA;
        ansB.GetComponent<Text>().text = newB;
    }
}
