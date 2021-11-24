using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class donus : MonoBehaviour
{
   public Rigidbody rb;
   private Vector2 kaydirmabaslangic;

   private Vector2 kaydirmabitis;
   public float itis=5f;
   public float tork=20f;
   public GameObject basarisizpanel;
   public GameObject basarilipanel;
   public Text kazanilanaltin;
   int toplananaltin = 0;
   public AudioSource basarilises;
   public AudioSource bicakdonus;
   public AudioSource bicakkesme;
   
   

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            kaydirmabaslangic = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            kaydirmabitis = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Kaydirma();
        }
    }

    void Kaydirma ()
    {
        rb.isKinematic=false;
        
        Vector2 kaydirma = kaydirmabitis - kaydirmabaslangic;
        rb.AddForce(kaydirma*itis,ForceMode.Impulse);
        rb.AddTorque(0f,0f,-tork, ForceMode.Impulse);
        bicakdonus.Play();


    }
    void OnTriggerEnter(Collider other) 
   {
       if (other.gameObject.tag == "pizza")
       {
           toplananaltin++;
           bicakkesme.Play();
       }
       if (other.gameObject.tag == "karpuz")
       {
           toplananaltin++;
           bicakkesme.Play();
       }
   }
    
     void OnCollisionEnter(Collision other)
    {
     if (other.gameObject.tag == "zemin")
     {
         
         Time.timeScale = 0;
         basarisizpanel.SetActive(true);
     }  
     
        if (other.gameObject.tag=="tahta")
        {
            rb.isKinematic=true; 
        }

    if (other.gameObject.tag == "bitis")
    {
        Time.timeScale = 0;
        basarilipanel.SetActive(true);
        kazanilanaltin.text = toplananaltin.ToString();
        basarilises.Play();
    } 
    if (other.gameObject.tag == "bitis2")
    {
        Time.timeScale = 0;
        basarilipanel.SetActive(true);
        kazanilanaltin.text = (toplananaltin*2).ToString();
        basarilises.Play();
    }
    if (other.gameObject.tag == "bitis3")
    {
        Time.timeScale = 0;
        basarilipanel.SetActive(true);
        kazanilanaltin.text = (toplananaltin*3).ToString();
        basarilises.Play();
    }
    if (other.gameObject.tag == "bitis4")
    {
        Time.timeScale = 0;
        basarilipanel.SetActive(true);
        kazanilanaltin.text = (toplananaltin*4).ToString();
        basarilises.Play();
    }
    if (other.gameObject.tag == "bitis5")
    {
        Time.timeScale = 0;
        basarilipanel.SetActive(true);
        kazanilanaltin.text = (toplananaltin*5).ToString();
        basarilises.Play();
    }
    if (other.gameObject.tag == "bitis6")
    {
        Time.timeScale = 0;
        basarilipanel.SetActive(true);
        kazanilanaltin.text = (toplananaltin*6).ToString();
        basarilises.Play();
    }
    if (other.gameObject.tag == "bitis7")
    {
        Time.timeScale = 0;
        basarilipanel.SetActive(true);
        kazanilanaltin.text = (toplananaltin*7).ToString();
        basarilises.Play();
    }
    if (other.gameObject.tag == "bitis8")
    {
        Time.timeScale = 0;
        basarilipanel.SetActive(true);
        kazanilanaltin.text = (toplananaltin*8).ToString();
        basarilises.Play();
    }
    if (other.gameObject.tag == "bitis9")
    {
        Time.timeScale = 0;
        basarilipanel.SetActive(true);
        kazanilanaltin.text = (toplananaltin*9).ToString();
        basarilises.Play();
    }


    }
    

}
