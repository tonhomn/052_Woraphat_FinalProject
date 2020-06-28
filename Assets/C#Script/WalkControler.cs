using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkControler : MonoBehaviour
{
    private Animator walk;
    // Start is called before the first frame update
    void Start()
    {
        walk = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            walk.SetBool("w",true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            walk.SetBool("w",false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            walk.SetBool("a",true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            walk.SetBool("a",false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            walk.SetBool("s",true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            walk.SetBool("s",false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            walk.SetBool("d",true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            walk.SetBool("d",false);
        }
    }
}
