using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{

    
    public int nextlevel;


    void OnTriggerEnter(Collider col)
    {
        LoadNextLevel(nextlevel);
    }

    void LoadNextLevel(int x)
    {
        SceneManager.LoadScene(x);

    }
}
