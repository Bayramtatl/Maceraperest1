using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthboxScript : MonoBehaviour
{
    public int healthToGive = 25;
    public int a;
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
            a= FindObjectOfType<HealthManager>().HealPlayer(healthToGive);
        }
        if (a != 0)
        {
            Destroy(gameObject);
        }
    }
}
