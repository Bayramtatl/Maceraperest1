using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthboxScript : MonoBehaviour
{
    public int healthToGive = 25;
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
            FindObjectOfType<HealthManager>().HealPlayer(healthToGive);
        }
        Destroy(gameObject);
    }
}
