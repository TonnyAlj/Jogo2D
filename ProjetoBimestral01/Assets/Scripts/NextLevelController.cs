using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelController : MonoBehaviour
{
    public int nextLevel;
    public int sceneName;
    public void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void Restart(){
        SceneManager.LoadScene(sceneName);
    }

    public void StartMenu(){
        SceneManager.LoadScene(0);
    }
}
