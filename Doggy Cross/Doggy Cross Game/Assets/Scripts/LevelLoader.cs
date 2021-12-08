using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string levelName;
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
        if (other.gameObject.name == "LoadLevel2")
        {
            Debug.Log("detected");
            SceneManager.LoadScene("Level2");
        }
        else if (other.gameObject.name == "LoadLevel3")
        {
            Debug.Log("detected");
            SceneManager.LoadScene("Level3");
        }
        else if(other.gameObject.name == "GameComplete")
        {
            SceneManager.LoadScene("Completed");
        }
    }
}
