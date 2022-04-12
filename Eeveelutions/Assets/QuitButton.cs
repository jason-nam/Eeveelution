using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    [SerializeField] private string startView = "StartView";
    
    public void QuitGame()
    {
        SceneManager.LoadScene(startView);
    }
}
