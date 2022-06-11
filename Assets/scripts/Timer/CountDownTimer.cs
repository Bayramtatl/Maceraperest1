using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public static CountDownTimer instance;
    public Text countDownText;
    float t;
    string minutes;
    string seconds;
    

    void Awake()
    {
        instance = this;
        

    }

    private void Update()
    {

        //currentTime += 1 * Time.deltaTime;
        //t = Time.time - 0;
        if (SceneManager.GetActiveScene().name == "map1")
        {
            t = Time.timeSinceLevelLoad;
            minutes = ((int)t / 60).ToString();
            seconds = (t % 60).ToString("f1");
            countDownText.text = minutes + "." + seconds;

        }
        else
        {
            t = Time.time - 0;
            minutes = ((int)t / 60).ToString();
            seconds = (t % 60).ToString("f1");
            countDownText.text = minutes + "." + seconds;

        }

       
    }

    public void resetTime()
    {

        
       
    }

}
