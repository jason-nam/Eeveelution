using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyUI : MonoBehaviour {
    
    public float timer = 0.0f;
    public int health;
    private int currency;

    void Start() {
        timer = 0.0f;
        health = 10;
        health = PlayerPrefs.GetInt("Health");
        currency = 0;
        currency = PlayerPrefs.GetInt("Currency");
    }

    void Update() {

        timer += Time.deltaTime;
        if (timer > 3) {
            health = PlayerPrefs.GetInt("Health");
            if (health > 0) {
                health -= 1;
                PlayerPrefs.SetInt("Health", health);
                currency += 10;
                PlayerPrefs.SetInt("Currency", currency);
                timer = 0;
                PlayerPrefs.Save();
            }
        }
    }
}
