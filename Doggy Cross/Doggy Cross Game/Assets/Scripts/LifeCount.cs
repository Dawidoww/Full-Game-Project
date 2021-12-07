using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesLeft;
    //public string name;

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
        gameObject.transform.position = new Vector3(-10, 4, 10);
        LoseLife();
    }

    public void LoseLife()
    {
        livesLeft--;
        lives[livesLeft].enabled = false;

        if (livesLeft == 0)
        {
            //load scene after losing
            SceneManager.LoadScene("MainMenu");
            Debug.Log("Lost");
        }
    }
}
