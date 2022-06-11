using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Finish_Menu_Script : MonoBehaviour

{

    public Text finishStateText;

    // Start is called before the first frame update
    void Start()
    {
        
        //Debug.Log(HealthManager.instance.maxHealth);
        finishStateText.text = HealthManager.instance.Sayac.text + " " + "Time: " + CountDownTimer.instance.countDownText.text;

    }


   
}
