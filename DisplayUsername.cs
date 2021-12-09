using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUsername : MonoBehaviour
{
    public Text usernameBox;

    public void Start()
    {
        usernameBox.text = PlayerPrefs.GetString("Username");
    }
}
