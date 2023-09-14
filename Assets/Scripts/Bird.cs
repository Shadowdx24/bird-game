using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] Rigidbody2D body;
    [Range(0,10) ,SerializeField] float speed = 5f, jumpspeed = 5f;
    [SerializeField] Animator animator;
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
}
