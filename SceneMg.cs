using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMg : MonoBehaviour
{
    [SerializeField] GameObject panelQuit;

    public void QuitGame()
    {
        panelQuit.SetActive(true);
        //Application.Quit();
        //Debug.Log("Quit!");
    }

    public void onClickYesNo(int choice) //choice==0, No; choice==1, Yes
    {
        if(choice == 1)
        {
            Application.Quit();
            Debug.Log("Quit!");
        }
        panelQuit.SetActive(false);
    }

}
