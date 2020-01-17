using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    public void Restart()
    {        
        SceneManager.LoadScene("Level 1");
    }

    public void doExitGame()
    {
        Application.Quit();
    }
}
