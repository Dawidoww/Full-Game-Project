using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesLeft;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "car1" || other.gameObject.tag == "car2") 
        {
            LoseLife();
        }
    }

    public void LoseLife()
    {
        
        livesLeft--;
        lives[livesLeft].enabled = false;

        if (livesLeft == 0)
        {
            //load scene after losing
            SceneManager.LoadScene("TryAgain");
            Debug.Log("Lost");
        }
    }
}
