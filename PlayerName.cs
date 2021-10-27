using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public string playerName;
    public string saveName;
    public Text inputText;
    //public Text loadedName;

    // Update is called once per frame
    void Update()
    {
        playerName = PlayerPrefs.GetString("name", "username");
        //loadedName.text = playerName;
    }

    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }
}
