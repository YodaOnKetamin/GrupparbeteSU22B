using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour
{
    [SerializeField]
    private Transform ghostPoint1;
    [SerializeField]
    private Transform ghostPoint2;
    [SerializeField]
    private float moverange;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = ghostPoint1.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if ()
        {

        }
        transform.position = Vector3.MoveTowards(transform.position, ghostPoint2.position, moverange*Time.deltaTime);
       
    }
}
