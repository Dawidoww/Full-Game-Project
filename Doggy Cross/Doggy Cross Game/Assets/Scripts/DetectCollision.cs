using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public int x = -10;
    public int y = 4;
    public int z = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "car1")
        {
            gameObject.transform.position = new Vector3(x,y,z);
        }
        if (other.gameObject.tag == "car2")
        {
            gameObject.transform.position = new Vector3(x, y, z);
        }

    }
}
