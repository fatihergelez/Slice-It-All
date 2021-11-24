using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kesilen : MonoBehaviour
{
   public GameObject pizza;
   public GameObject parcalipizza;
   
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision other) {
        

        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "bicak")
        {
            
            Instantiate(parcalipizza, new Vector3(pizza.transform.position.x, pizza.transform.position.y, pizza.transform.position.z ), Quaternion.identity);
           

            Destroy(gameObject);
        }
    }

   
    void Update()
    {
        
    }
}
