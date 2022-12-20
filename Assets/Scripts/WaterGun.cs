using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGun : MonoBehaviour
{
    [SerializeField]
    private KeyCode fireKey = KeyCode.Mouse0;

    private bool isFiring = false;
    [SerializeField] 
    private GameObject pelletPrefab;
    
    [SerializeField] 
    private Transform shootPoint;

    [SerializeField]
    private Rigidbody2D playerRigidBody;

    private Vector3 force;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Made a bool to check if the player is firing, and I made it in Fixedupdate so I have a ocnstant rate of fire
        if (isFiring)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 shootDir = mousePos - (Vector2)transform.position;
            force = shootDir.normalized * 500;
            GameObject pellet = Instantiate(pelletPrefab, shootPoint.position, new Quaternion(0, 0, 90, 0));
            pellet.GetComponent<WaterPellet>().SetForce(force);
            playerRigidBody.AddForce((force *-1)/50);
            
        }
        
    }
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 shootDir = mousePos - (Vector2)transform.position;
        float angle = Mathf.Atan2(shootDir.y, shootDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        
        //Checks if the player is pressing the fire key
        if (Input.GetKey(fireKey))
        {
            isFiring = true;
        } else
        {
            isFiring = false;
        }
        
    }
}

