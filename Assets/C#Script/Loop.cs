using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loop : MonoBehaviour
{
    void loop()
    {
        SceneManager.LoadScene("Trophy");
    }
    
    void Start()
    {
        Invoke("loop", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
