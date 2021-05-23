using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float thrusterforce = 1000f;
    [SerializeField] public float tiltingforce = 50f;

    bool thrust = false;

    float fuel = 999f;

    Rigidbody rb;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {

    }
    private void Update()
    {
        float tilt = Input.GetAxis("Horizontal");
        thrust = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space);

        if (!Mathf.Approximately(tilt, 0f))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, 0f, -(tilt * tiltingforce * Time.deltaTime)));
        }
        rb.freezeRotation = false;
    }
    private void FixedUpdate()
    {
        if (thrust)
        {
            if (fuel > 0)
            {
                rb.AddRelativeForce(Vector3.up * thrusterforce * Time.deltaTime);
                fuel -= 1;
                FuelScript.fuelvalue -= 1;
                print(fuel);
            }
            //rb.AddRelativeForce(Vector3.up * thrusterforce *Time.deltaTime);
        }
    }
}
