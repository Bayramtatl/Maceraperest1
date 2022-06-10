using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{
    public static bool gameIsPause = false;
    public GameObject Panel;
    public GameObject Button1;
    public GameObject Button2;
    // Update is called once per frame
    void Start()
    {
        Panel.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPause == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        Panel.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
        Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Confined;
    }
    public void Pause()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Panel.SetActive(true);
        Button1.SetActive(true);
        Button2.SetActive(true);
        Time.timeScale = 0f;
        gameIsPause = true;
    }
    public void Ana_Menu()
    {
        SceneManager.LoadScene("Menu");
    }

}
