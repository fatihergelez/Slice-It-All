using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kesilenkarpuz : MonoBehaviour
{
    public GameObject karpuzparca1;
    
    

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
         if (other.gameObject.tag == "bicak")
         {
             Instantiate(karpuzparca1,(gameObject.transform.position),Quaternion.identity);
             
             Destroy(gameObject);
             
         }
        
    }
    void Update()
    {
        
    }
}
