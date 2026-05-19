using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudscript : MonoBehaviour
{
    void Start()
    {
        GameObject.FindWithTag("cloud").GetComponent<Rigidbody2D>().velocity = new Vector2(-1,0);
        GameObject.FindWithTag("cloud2").GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0);
    }

    void Update()
    {
        if(GameObject.FindWithTag("cloud").GetComponent<Rigidbody2D>().position.x <= -10.8)
        {
            float randomy = Random.Range(-0.5f, 2.5f); 
            GameObject.FindWithTag("cloud").GetComponent<Rigidbody2D>().transform.position = new Vector2(10.8f, randomy);
        }
        if (GameObject.FindWithTag("cloud2").GetComponent<Rigidbody2D>().position.x <= -10.8)
        {
            float randomy = Random.Range(-0.5f, 2.5f);
            GameObject.FindWithTag("cloud2").GetComponent<Rigidbody2D>().transform.position = new Vector2(10.8f, randomy);
        }
    }
}
