﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour

{

    public float jumpFactor = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit the player");
           
            collision.gameObject.GetComponent<Rigidbody>().AddForce(jumpFactor * this.transform.up);
        }
    }
}
