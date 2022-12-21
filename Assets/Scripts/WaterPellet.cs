using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPellet : MonoBehaviour
{
    private Vector3 force;

    private Rigidbody2D rb;

    public bool touchGround = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(force);
        transform.Rotate(0, 0, 90);
    }

    private void Update()
    {
        if (!touchGround)
        {
            Vector2 v = rb.velocity.normalized;
            float angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.Rotate(0, 0, 90);
        }
       
    }

    public void SetForce(Vector3 force)
    {
        this.force = force;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.CompareTag("golv"))
        {
          Destroy(gameObject);
        }else if(col.gameObject.CompareTag("WaterPellet"))
        {
            print("Hit another pellet!");
            WaterPellet pellet = col.gameObject.GetComponent<WaterPellet>();
            if (pellet.touchGround)
            {
                print("Hit another pellet that is on the ground!");
                rb.constraints = RigidbodyConstraints2D.None;
                touchGround = true;
            }
        }
        
    }
}
