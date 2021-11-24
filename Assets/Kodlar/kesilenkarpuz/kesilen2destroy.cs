using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kesilen2destroy : MonoBehaviour
{
    

    void Start()
    {
        
    }

     
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "bicak")
         {
            
             Destroy(gameObject);
         }
        
    }
    void Update()
    {
        
    }
}