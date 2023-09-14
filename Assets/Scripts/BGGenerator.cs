using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGGenerator : MonoBehaviour
{

    public GameObject bgPrefab;
    public Transform genpoint;
    float distance = 17.4f;
    //[SerializeField] private List<GameObject> allBgPrefab;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("genpoint = > " + genpoint.transform.position);
        if (genpoint.position.x > transform.position.x)
        {
            transform.position = new Vector2(transform.position.x + distance, transform.position.y);
             Instantiate(bgPrefab, transform.position, Quaternion.identity);
            
            //for (int i = 0; i < allBgPrefab.Count; i++)
            //{
            //    if (!allBgPrefab[i].gameObject.activeInHierarchy)
            //    {
            //        allBgPrefab[i].gameObject.SetActive(true);
            //        allBgPrefab[i].transform.position = transform.position;
            //        break;
            //    }
            //}
        }
    }
}
