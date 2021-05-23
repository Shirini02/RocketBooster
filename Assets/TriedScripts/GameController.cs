using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public RocketMovement Rocket;
    public Camera camfollow;
    public float camOffsetz;
    Vector3 camoffset;
    // Start is called before the first frame update
    void Start()
    {
        camoffset = new Vector3(0, 0, camOffsetz);
    }

    // Update is called once per frame
    void Update()
    {
        if (Rocket != null)
        {
            camfollow.transform.position = new Vector3(camfollow.transform.position.x, Rocket.transform.position.y, camfollow.transform.position.z);

        }
    }
}
