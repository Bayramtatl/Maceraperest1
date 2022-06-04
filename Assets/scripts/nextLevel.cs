using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{

    
    public int nextlevel = 1;
    // Start is called before the first frame update
    void Start()
    {
         
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        LoadNextLevel(nextlevel);
    }

    void LoadNextLevel(int x)
    {
        SceneManager.LoadScene(x);

    }
}
