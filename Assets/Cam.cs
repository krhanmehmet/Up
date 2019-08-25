using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{

    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            this.transform.SetPositionAndRotation(new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z - 20), this.transform.rotation);
        }
    }
}
