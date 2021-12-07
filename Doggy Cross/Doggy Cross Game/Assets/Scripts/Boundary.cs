using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= 57)
        {
            transform.position = new Vector3(36, transform.position.y, transform.position.x);
        }
        if (transform.position.z <= -30)
        {
            transform.position = new Vector3(-8, transform.position.y, transform.position.x);
        }
    }
}
