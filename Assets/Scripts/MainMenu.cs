using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("Difficulty Select");
    }
    public void Instructions(){
        SceneManager.LoadScene("instructions");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
