using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifSelect : MonoBehaviour
{
    public void Easy() {
        SceneManager.LoadScene("Easy");
    }
        public void Normal() {
        SceneManager.LoadScene("Normal");
    }
        public void Hard() {
        SceneManager.LoadScene("Hard");
    }
        public void Nightmare() {
        SceneManager.LoadScene("Nightmare");
    }
        public void Back() {
        SceneManager.LoadScene("main menu");
    }
}
