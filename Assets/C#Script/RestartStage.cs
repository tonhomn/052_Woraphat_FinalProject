using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartStage : MonoBehaviour
{
    public static string thisScene;
    public void Start()
    {
        thisScene = SceneManager.GetActiveScene().name;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            SceneManager.LoadScene("DeadScene");
        }
    }
}
