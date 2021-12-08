using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float multiplier = 1.5f;
    public float duration = 3f;
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
        if (other.gameObject.tag == "PlayerDog")
        {
            StartCoroutine( PickUp(other));
        }

        IEnumerator PickUp(Collider player)
        {
            PlayerControl speed = player.GetComponent<PlayerControl>();
            speed.speed *= multiplier;

            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            yield return new WaitForSeconds(duration);
            speed.speed /= multiplier;
            Destroy(gameObject);
        }
    }
}
