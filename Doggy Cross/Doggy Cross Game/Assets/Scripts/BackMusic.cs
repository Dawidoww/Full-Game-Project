using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static BackMusic BackInstance;
    
    private void Awake(){
        if(BackInstance != null && BackInstance != this){
            Destroy(this.gameObject);
            return;
        }
        BackInstance = this;
        DontDestroyOnLoad(this);
    }
}
