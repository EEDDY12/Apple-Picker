using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndYes : MonoBehaviour
{
    // Start is called before the first frame update

    public void EndYesButton()
    { 
        SceneManager.LoadScene("_Scene_0");
    }
    // public void EndNoButton()
    // {
    //     SceneManager.LoadScene("StartScreen");
    // }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
