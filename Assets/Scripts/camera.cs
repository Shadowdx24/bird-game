using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] Transform cameraTransform; // Camera target
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - cameraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =new Vector3(cameraTransform.position.x + offset.x,transform.position.y,transform.position.z); 
        
    }
}
