using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextlevel : MonoBehaviour
{
    public void nextlevell()
    {
        SceneManager.LoadScene("level2");
    }
    public void exitgame()
    {
        Debug.Log("Exit Button Pressed");
        Application.Quit();
    }
}
