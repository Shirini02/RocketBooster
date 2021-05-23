using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameoverscript1 : MonoBehaviour
{
    public void GoToSecondScene()
    {

        SceneManager.LoadScene(1);



    }
    public void GoToFirstScene()
    {

        SceneManager.LoadScene(0);



    }

}
