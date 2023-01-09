using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Moveball : MonoBehaviour
{
    Rigidbody rb;                                                  //1:motion of ball
    public int ballspeed = 0;                                     //1:motion of ball 
    public int jumpspeed = 0;                                                             //2:Jump
    private bool istouching = true;                                                       //2:Jump
    private int counter;                                         //3:coin
    public Text Cointext;                                       //3:coin
    public AudioSource asource;                                                         //4:audio
    public AudioClip aclip;                                                            //4:audio
    void Start()
    {
        rb = GetComponent<Rigidbody>();                            //1:motion of ball
        counter = 0;                                        //3:coin
        Cointext.text = "Coins: " + counter;               //3:coin
    }

    void Update()
    {
        float Hmove = Input.GetAxis("Horizontal");             //1:motion of ball
        float Vmove = Input.GetAxis("Vertical");              //1:motion of ball
        Vector3 ballmove = new Vector3(Hmove, 0.0f, Vmove);  //1:motion of ball
        rb.AddForce(ballmove * ballspeed);                  //1:motion of ball



        if (Input.GetKey(KeyCode.Space) && istouching == true)       //2:Jump
        {
            Vector3 balljump = new Vector3(0.0f, 6.0f, 0.0f);        //2:Jump
            rb.AddForce(balljump * jumpspeed);                      //2:Jump
        } 
        istouching = false;                                        //2:Jump 
    }
    private void OnCollisionStay()                                //2:Jump
    {      
        istouching = true;                                       //2:Jump
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coinstag"))        //3:coin
        {  
            other.gameObject.SetActive(false);             //3:coin


            counter = counter + 1;                      //3:coin
            Cointext.text = "Coins: " + counter;       //3:coin


            asource.PlayOneShot(aclip);                               //4:audio
           
            
            if (counter == 15)
            {
                SceneManager.LoadScene("nextlevel");
            }
        }
    }
    
}
