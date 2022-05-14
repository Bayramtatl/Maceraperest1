using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformAttach : MonoBehaviour {

    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.parent = null;
        }
    }
}
