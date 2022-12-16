using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key1 : MonoBehaviour
{
    public bool hasKey;
    // Start is called before the first frame update
    void Start()
    {
        hasKey = false;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "player")
        {
            Destroy(gameObject);
            hasKey = true;
        } 
    }
}
