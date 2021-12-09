using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /*public void QuitGame()
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
    }*/

    public void OkButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
