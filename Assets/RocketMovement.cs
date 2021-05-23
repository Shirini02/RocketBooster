using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RocketMovement : MonoBehaviour
{
    bool thrust = false;

    public float fuel = 999f;

    public float rocketspeed;
   // public GameObject GameOver;
    //public float rocketspeed;
    Rigidbody rb;
    public static bool gameOver;
    public GameObject gameoverpanel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    
    }
    private void Update()
    {
        thrust = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space);
    }

        // Update is called once per frame
        void FixedUpdate()
    {
        if (thrust)
        {
            if (fuel > 0)
            {
                rb.AddRelativeForce(Vector3.up * rocketspeed * Time.deltaTime);
                fuel -= 1;
                FuelScript.fuelvalue -= 1;
                print(fuel);
            }
            //rb.AddRelativeForce(Vector3.up * thrusterforce *Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //moves towards left
            transform.Translate(Vector3.left* Time.deltaTime * rocketspeed);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Moves towards right
             transform.Translate(Vector3.right* Time.deltaTime * rocketspeed);
           
        }
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * rocketspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.back * rocketspeed * Time.deltaTime);
        }
        
            booster();
    }
  

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        
        if (collision.gameObject.tag == "obstacle")
        {
            Destroy(gameObject, 0);
            SceneManager.LoadScene(2);

            //Debug.Log("GAME OVER");
        }
        if (collision.gameObject.tag == "Endpoint")
        {
            SceneManager.LoadScene(3);

            //Debug.Log("GAME OVER");
        }



    }
    private void booster()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //moves in upward direction
            transform.Translate(Vector3.up * rocketspeed * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //moves in downward direction
            transform.Translate(new Vector3(0, -rocketspeed, 0) * Time.deltaTime);
            
        }
        
        

    }
    
        
    }


   


