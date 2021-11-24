using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kesilenkarpuz2 : MonoBehaviour
{
    public GameObject karpuzparca2;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "bicak")
         {
             Instantiate(karpuzparca2,(gameObject.transform.position),Quaternion.identity);
             Destroy(gameObject);
         }
    }
    void Update()
    {
        
    }
}
