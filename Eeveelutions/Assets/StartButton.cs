using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

    [SerializeField] private string mainView = "MainView";
    private int initFood = 0;
    private int initHealth = 10;
    private int initCurrency = 0;
    private int initFire = 0;
    private int initWater = 0;
    private int initElectric = 0;
    
    public void StartGame() {

        SetDefaults();
        SceneManager.LoadScene(mainView);
    
    }

    public void SetDefaults() {

        PlayerPrefs.SetInt("Food", initFood);
        PlayerPrefs.SetInt("Health", initHealth);
        PlayerPrefs.SetInt("Currency", initCurrency);
        PlayerPrefs.SetInt("Fire", initFire);
        PlayerPrefs.SetInt("Water", initWater);
        PlayerPrefs.SetInt("Electric", initElectric);
        PlayerPrefs.Save();

    }
}
