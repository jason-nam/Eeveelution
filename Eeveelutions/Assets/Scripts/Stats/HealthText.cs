using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour {
    
    public Text healthText;

    void Start() {

        healthText.text = PlayerPrefs.GetInt("Health").ToString();
    
    }

    void Update() {

        healthText.text = PlayerPrefs.GetInt("Health").ToString();

    }
}
