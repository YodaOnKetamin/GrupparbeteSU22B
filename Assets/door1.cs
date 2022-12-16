using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door1 : MonoBehaviour
{
    key1 hasKey;
    
    // Start is called before the first frame update
    void Start()
    {
        hasKey = FindObjectOfType<key1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "player" && hasKey.hasKey == true )
        {
            Destroy(gameObject);
            hasKey.hasKey = false;
        }

    }
}
