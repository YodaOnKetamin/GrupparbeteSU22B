using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    KeyCode left;

    [SerializeField]
    KeyCode right;

    [SerializeField]
    int speed;

    [SerializeField]
    KeyCode jump;

    [SerializeField]
    int jumpForce;

    Rigidbody2D rb;

    public bool hasjumped = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }//g� v�nster
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }//g� h�ger
        if (Input.GetKeyDown(jump) && hasjumped == false)
        {
            rb.AddForce(transform.up * jumpForce);
            hasjumped = true;
        }//hoppa
    }//h�ger v�nster movement

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "golv")
        {
            hasjumped = false;
        }//f�r hoppa n�r nuddar tagen golv
    }//g�r s� att man inte kan dubbelhoppa

}
