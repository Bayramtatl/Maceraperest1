using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoSpawn : MonoBehaviour
{
    public Transform Spawn;
    // Start is called before the first frame update
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            //gameObject.GetComponent<ThirdPersonController>().enabled = false;
            gameObject.transform.position = Spawn.position;
            //gameObject.GetComponent<ThirdPersonController>().enabled = true;
        }

    }
}
