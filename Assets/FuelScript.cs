using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour
{
    public static float fuelvalue = 999f;
    Text fuel;
    // Start is called before the first frame update
    void Start()
    {
        fuel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        fuel.text = "FUEL : " + fuelvalue;
    }
}
