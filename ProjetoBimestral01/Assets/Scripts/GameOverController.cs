using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public int sceneName;

    public void StartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadScene(){
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }
}
