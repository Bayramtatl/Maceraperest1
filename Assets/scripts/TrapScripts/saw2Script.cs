using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw2Script : MonoBehaviour
{
    public int damageToGive = 35;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<HealthManager>().HurtPlayer(damageToGive);
        }
    }
}
