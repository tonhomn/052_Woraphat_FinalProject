using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitToRestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("RestartSecne", 3.0f);
    }

    // Update is called once per frame
    void RestartSecne()
    {
        SceneManager.LoadScene(RestartStage.thisScene);
    }
}
