using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    int speedamount=10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(transform.position.x<=6.8)
        {
            speedamount = 10;
        }
        if (transform.position.x >=13.1)
        {
            speedamount = -10;
        }
        transform.Translate(speedamount * Time.deltaTime,0, 0);
       


    }
}
