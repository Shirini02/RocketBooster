using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Levelcompleted : MonoBehaviour
{
    Text gameover;
    void Start()
    {
        gameover = GetComponent<Text>();
    }



   
        public void OnCollisionEnter(Collision collision)
        {


            if (collision.gameObject.tag == "Endpoint")
            {
                gameover.text = "Game Over";
            }


        }
    
}