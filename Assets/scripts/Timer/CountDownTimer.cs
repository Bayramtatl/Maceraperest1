using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{

    public Text countDownText;
    private void Start()
    {
        Debug.Log("Timer");
    }

    private void Update()
    {
      
        //currentTime += 1 * Time.deltaTime;
        float t = Time.time - 0;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f1");
        countDownText.text = minutes+ "."+ seconds;
    }

}
