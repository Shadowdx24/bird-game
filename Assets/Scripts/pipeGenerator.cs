using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeGenerator : MonoBehaviour
{
    [SerializeField] GameObject pipePerfab;
    [SerializeField] private Transform pipeContainer;
    
    //private float distance =4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        InvokeRepeating("PipeGenerator", 0f,60f);
    }
    private void PipeGenerator()
    {
        float ranX = Random.Range(5f, 20f);
        float ranY = Random.Range(-4.2f, 2.74f);
        transform.position = new Vector3(transform.position.x + ranX, ranY,-10f);
        Instantiate(pipePerfab, transform.position, Quaternion.identity, pipeContainer);
    }

}
