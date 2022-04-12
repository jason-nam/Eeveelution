using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    [SerializeField] private string mainView = "MainView";
    
    public void StartGame()
    {
        SceneManager.LoadScene(mainView);
    }
}
