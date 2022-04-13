using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryText : MonoBehaviour {

    public Text foodText;
    public Text fireStoneText;
    public Text waterStoneText;
    public Text electricStoneText;
    public GameObject foodItem;
    public GameObject fireItem;
    public GameObject waterItem;
    public GameObject electricItem;

    public void Start() {
        
        foodText.text = PlayerPrefs.GetInt("Food").ToString();
        fireStoneText.text = PlayerPrefs.GetInt("Fire").ToString();
        waterStoneText.text = PlayerPrefs.GetInt("Water").ToString();
        electricStoneText.text = PlayerPrefs.GetInt("Electric").ToString();
    
    }

    public void Update() {

        if (PlayerPrefs.GetInt("Food") > 0)
        {
            foodItem.SetActive(true);
            foodText.text = PlayerPrefs.GetInt("Food").ToString();
        }
        else
        {
            foodItem.SetActive(false);
            foodText.text = "";
        }
        if (PlayerPrefs.GetInt("Fire") > 0)
        {
            fireItem.SetActive(true);
            fireStoneText.text = PlayerPrefs.GetInt("Fire").ToString();
        }
        else
        {
            fireItem.SetActive(false);
            fireStoneText.text = "";
        }
        if (PlayerPrefs.GetInt("Water") > 0)
        {
            waterItem.SetActive(true);
            waterStoneText.text = PlayerPrefs.GetInt("Water").ToString();
        }
        else
        {
            waterItem.SetActive(false);
            waterStoneText.text = "";
        }
        if (PlayerPrefs.GetInt("Electric") > 0)
        {
            electricItem.SetActive(true);
            electricStoneText.text = PlayerPrefs.GetInt("Electric").ToString();
        }
        else
        {
            electricItem.SetActive(false);
            electricStoneText.text = "";
        }
    }

}
