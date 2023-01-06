using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{  
    public void BackButton() {
        SceneManager.LoadScene("main menu");
    }
}
