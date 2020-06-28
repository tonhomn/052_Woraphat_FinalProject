using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    private int count;
    public Text countText;
    void Start()
    {
        count = 0;
        countText.text = "Score :" + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            other.gameObject.SetActive(false);
            count = count + 5;
            countText.text = "Score :" + count.ToString();
        }
        
    }
}
