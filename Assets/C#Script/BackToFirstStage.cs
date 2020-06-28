using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToFirstStage : MonoBehaviour
{
    void GoFirstStage()
    {
        SceneManager.LoadScene("FirstStage");
    }
    
    void Start()
    {
        Invoke("GoFirstStage", 10.0f);
    }
}
