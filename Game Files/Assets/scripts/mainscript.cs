using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainscript : MonoBehaviour
{
    public AudioSource jump;
    public AudioSource defeat;
    public Animator pengu;
    public TMPro.TextMeshProUGUI hightext;
    public TMPro.TextMeshProUGUI pointtext;
    public Rigidbody2D barrier;
    public float bullshit = 0;
    public int point = 0;
    public GameObject canvas;

    private void Start()
    {
        Time.timeScale = 1f;

        barrier.velocity = new Vector2(-4, 0);
        hightext.text = PlayerPrefs.GetInt("highscore").ToString();
    }

    void FixedUpdate()
    {
        bullshit++;

        if(bullshit % 10 == 0)
        {
            point++;
            pointtext.text = point.ToString();

            if (point > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", point);
            }

            if (point % 250 == 0  &&  point <= 2000)
            {
                barrier.velocity += new Vector2(-1, 0);
            }
        }

        if (GetComponent<Rigidbody2D>().position.x > -4.685  && GetComponent<Rigidbody2D>().position.x < -4.675)
        {
            float Randomy = Random.Range(-2.45f, -0.5f);

            if (barrier.position.x <= -9.6)
            {
                barrier.transform.position = new Vector3(9.6f, Randomy, transform.position.z);
                pengu.SetTrigger("walk");
                barrier.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
        else
        {
            canvas.SetActive(true);
            Time.timeScale = 0f;
            defeat.Play();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)  ||  Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(barrier.GetComponent<BoxCollider2D>().enabled == false)
            {
                pengu.SetTrigger("walk");
                barrier.GetComponent<BoxCollider2D>().enabled = true;
            }
            else
            {
                if (GetComponent<Rigidbody2D>().position.y <= -0.75)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 9);
                    jump.Play();
                }
            }

            barrier.GetComponent<BoxCollider2D>().enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)  && barrier.transform.position.y >= -1.25)
        {
            barrier.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    public void button()
    {
        SceneManager.LoadScene(1);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void exitgame()
    {
        Application.Quit();
    }
}
