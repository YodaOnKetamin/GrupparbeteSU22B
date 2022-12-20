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

    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = ghostPoint1.position;
        target = ghostPoint2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moverange * Time.deltaTime);
        if (transform.position == ghostPoint2.position && target == ghostPoint2)
        {
            target = ghostPoint1;
        }
        else if (transform.position == ghostPoint1.position && target == ghostPoint1)
        {
            target = ghostPoint2;
        }
       
    }
}
