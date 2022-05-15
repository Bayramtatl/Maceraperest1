using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{

    public Image healthBar;

    public void UptadeHealth(float fraction)
    {
        healthBar.fillAmount = fraction;
    }


}
