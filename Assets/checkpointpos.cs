using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointpos : MonoBehaviour
{
    private gamemaster gm;
    
    public GameObject invetory;
    float hart;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<gamemaster>();
        
        
    }
        // Update is called once per frame
        void Update()
    {
       
    }
}
