using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Start_Menu_Script : MonoBehaviour
{
    public void LoadGame()
    {
        CountDownTimer.instance.resetTime();
        SceneManager.LoadScene(0);
        
    }
    public void EndGame()
    {
        Application.Quit();
    }
}
