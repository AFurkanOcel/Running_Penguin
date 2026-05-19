using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcode : MonoBehaviour
{
    public Animator pengu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)  ||  Input.GetKeyDown(KeyCode.Space))
        {
            pengu.SetTrigger("walk");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)  &&  GetComponent<Rigidbody2D>().position.y <= -0.75)
        {
            pengu.SetTrigger("slide");
        }
    }
}
