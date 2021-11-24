using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kesilen2 : MonoBehaviour
{
   public GameObject spawn;
   public GameObject parcalipizza1;
   

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "bicak")
        {
            
            Instantiate(parcalipizza1, new Vector3(spawn.transform.position.x,spawn.transform.position.y, spawn.transform.position.z ), Quaternion.identity);
           

            Destroy(gameObject);
        }
    }

}