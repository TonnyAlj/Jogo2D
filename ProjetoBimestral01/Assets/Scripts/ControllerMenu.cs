using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerMenu : MonoBehaviour
{
    public void Jogar(){
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Sair(){
        Application.Quit();
    }
}
