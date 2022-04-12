using UnityEngine;
using UnityEngine.UI;

public class ShopCurrencyUI : MonoBehaviour {

    public Text currencyText;

    void Start() {

        currencyText.text = PlayerPrefs.GetInt("Currency").ToString();

    }

    void Update() {

        currencyText.text = PlayerPrefs.GetInt("Currency").ToString();
    
    }
}
