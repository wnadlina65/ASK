using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerData: MonoBehaviour
{
    public InputField inputText;
   
    public void clickOkButton()
    {
        PlayerPrefs.SetString("Username", inputText.text);
        Debug.Log("Your username is " + PlayerPrefs.GetString("Username"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
