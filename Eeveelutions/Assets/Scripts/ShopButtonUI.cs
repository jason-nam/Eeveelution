using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButtonUI : MonoBehaviour
{

    [SerializeField] private string shopView = "ShopView";

    public void ShopButton ()
    {
        SceneManager.LoadScene(shopView);
    }

}
