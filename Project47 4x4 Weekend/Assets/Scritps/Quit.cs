using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void Quitting()
    {
        Application.Quit();
        print("you have quite the game");
        SceneManager.LoadScene(0);
    }
}
