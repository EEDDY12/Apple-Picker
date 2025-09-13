using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
   
    public void YesButton()
    {
        SceneManager.LoadScene("_Scene_0");
    }

    public void NoButton()
    {
        SceneManager.LoadScene("StartScreen");
    }
    
}

