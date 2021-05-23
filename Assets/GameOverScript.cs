using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    Text gameover;
    RocketMovement RocketPlayer;
    // Start is called before the first frame update
    void Start()
    {
        gameover = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
      
            if (FuelScript.fuelvalue == 0f)
            {

            SceneManager.LoadScene(2);
        }
        }
    
}
