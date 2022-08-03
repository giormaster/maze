using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mymenu : MonoBehaviour
{
    public void onstart()
    {
        SceneManager.LoadScene("The maze");
    }
    public void onexit()
    {
        Application.Quit();
    }
}
