using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SecondBall : MonoBehaviour
{
    public GameObject rightPosition, leftPosition;
    bool cahngPosition;
    bool startGame;
    public float speed;
    void Start()
    {
        
    }
        
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * Time.deltaTime);

        //make it smooth vector3.lerp(a,b,time)
        if(cahngPosition == true && startGame==true)
        {
             transform.position = Vector3.Lerp(
                transform.position,
                new Vector3(rightPosition.transform.position.x, transform.position.y, transform.position.z),
                10f*Time.deltaTime);
        }

        if (cahngPosition == false && startGame == true)
        {
            transform.position = Vector3.Lerp(
                transform.position,
                new Vector3(leftPosition.transform.position.x, transform.position.y, transform.position.z),
                10f * Time.deltaTime);
        }


                                                     

        if (Input.GetMouseButtonDown(0))
        {

            startGame = true;

            if (cahngPosition == false)
            {
                cahngPosition = true;
            }
            else if(cahngPosition == true)
            {
                cahngPosition = false;
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {

       if (other.tag == "Wall")
        {
           transform.gameObject.SetActive(false); 
          SceneManager.LoadScene("level2");
        }

       

        if (other.tag == "Finish")
        {
            SceneManager.LoadScene("EndGame");
        }

    }
}
