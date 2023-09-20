using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject destoryer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.CompareTag("pipe") || collision.gameObject.CompareTag("bg")) 
        {
            
            Destroy(collision.gameObject);
        }
    }
}
