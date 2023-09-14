using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    [SerializeField] Rigidbody2D body;
    [Range(0,10) ,SerializeField] float speed = 5f, jumpspeed = 5f;
    [SerializeField] Animator animator;
    [SerializeField] GameObject losescene;
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
    private void lose()
    {
        losescene.SetActive(true);
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
    }
}
