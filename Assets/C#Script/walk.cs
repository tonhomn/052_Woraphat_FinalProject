using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class walk : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed;
    float rotate = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0f, 0f, -speed) * Time.deltaTime;
            if (rotate != 180f)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                rotate = 180;
            }
        }
        if (Input.GetKey(KeyCode.D))


        {
            transform.position += new Vector3(0f, 0f, speed) * Time.deltaTime;
            if (rotate != 0f)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                rotate = 0;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;
            if (rotate != 90f)
            {
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                rotate = 90;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(-speed, 0f, 0f) * Time.deltaTime;
            if (rotate != -90f)
            {
                transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                rotate = -90;
            }
        }
    }
}