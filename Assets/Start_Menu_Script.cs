using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Menu_Script : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(0);
    }
    public void EndGame()
    {
        Application.Quit();
    }
}
