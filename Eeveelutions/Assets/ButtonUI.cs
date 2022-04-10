using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{

    [SerializeField] private string gameLevel = "PetView";

    public void GameButton ()
    {
        SceneManager.LoadScene(gameLevel);
    }

}
