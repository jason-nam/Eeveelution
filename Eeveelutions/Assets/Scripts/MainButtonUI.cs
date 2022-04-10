using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtonUI : MonoBehaviour
{

    [SerializeField] private string mainView = "MainView";

    public void MainButton ()
    {
        SceneManager.LoadScene(mainView);
    }

}
