using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EeveeButtonUI : MonoBehaviour
{

    [SerializeField] private string petView = "PetView";

    public void EeveeButton ()
    {
        SceneManager.LoadScene(petView);
    }

}
