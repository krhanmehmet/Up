using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Collision collision;
    Rigidbody rigidbody;
    public float speed;
    public float jumpSpeed;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float h = Input.GetAxis("Horizontal");
        rigidbody.AddForce(new Vector3(h * speed, 0, 0));
        if(isGrounded && Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, jumpSpeed, 0));
        }
    }


  
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Debug.Log("Hit the ground");
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("Hit the ground");
            isGrounded = false;
        }   
    }
}
