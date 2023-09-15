using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    [SerializeField] Rigidbody2D body;
    [Range(0,10) ,SerializeField] float speed = 5f, jumpspeed = 5f;
    [SerializeField] Animator animator;
    [SerializeField] GameObject losescene;
    [SerializeField] GameObject pausescene;
    private int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        animator.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(speed, body.velocity.y);
        if (Input.GetMouseButton(0))
        {
            body.velocity=new Vector2(body.velocity.x,jumpspeed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("You lose");
            lose();
        }
    }

    public void pause()
    {
        pausescene.SetActive(true);
        scoreText.text = "Score: " + score;
        Time.timeScale = 0f;
    }
    private void lose()
    {
        losescene.SetActive(true);
        scoreText.text = "Score: " + score;
        Time.timeScale = 0f;
    }
    public void Exit()
    {
        //Application.Quit();
        Debug.Log("Exit");
    }

    public void Restart()
    {
        Debug.Log("Star Game");
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        score = 0;
    }

    public void Resume()
    {
        //Application.Quit();
        Debug.Log("Resume");
        pausescene.SetActive(false);
        scoreText.text = "Score: " + score;
        Time.timeScale = 1f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            score = score + 1;

        }   
    }
}
