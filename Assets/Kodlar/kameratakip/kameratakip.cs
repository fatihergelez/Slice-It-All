using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
    [SerializeField]
    public GameObject bicak;
    Vector3 aradakifark;
    
    void Start()
    {
        aradakifark = transform.position - bicak.transform.position;
    }
    void LateUpdate() 
    {
         transform.position = bicak.transform.position + aradakifark;       
    }
}
