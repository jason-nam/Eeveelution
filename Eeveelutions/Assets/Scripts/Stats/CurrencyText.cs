using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyText : MonoBehaviour {

    public Text currencyText;

    void Start() {

        currencyText.text = "$ " + PlayerPrefs.GetInt("Currency").ToString();

    }

    void Update() {

        currencyText.text = "$ " + PlayerPrefs.GetInt("Currency").ToString();

    }
}
