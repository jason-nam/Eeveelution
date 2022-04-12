using UnityEngine;
using UnityEngine.UI;

public class TransactionUI : MonoBehaviour {

    private int food;
    private int foodPrice = 5;
    private int currency;
    private int stonePrice = 200; 
    private int fireStone;
    private int waterStone;
    private int electricStone;

    public void Start() {
        food = 0;
        food = PlayerPrefs.GetInt("Food");
        foodPrice = 5;
        currency = 0;
        currency = PlayerPrefs.GetInt("Currency");
        stonePrice = 200;
        fireStone = 0;
        fireStone = PlayerPrefs.GetInt("Fire");
        waterStone = 0;
        waterStone = PlayerPrefs.GetInt("Water");
        electricStone = 0;
        electricStone = PlayerPrefs.GetInt("Electric");
    }


    public void BuyFood () {
        
        currency = PlayerPrefs.GetInt("Currency");
        if (currency >= foodPrice) {
            currency -= foodPrice;
            PlayerPrefs.SetInt("Currency", currency);
            food = PlayerPrefs.GetInt("Food");
            food += 1;
            PlayerPrefs.SetInt("Food", food);
            PlayerPrefs.Save();
        }

    }

    public void BuyWaterStone () {

        currency = PlayerPrefs.GetInt("Currency");
        if (currency >= stonePrice) {
          currency -= stonePrice;
          PlayerPrefs.SetInt("Currency", currency);
          waterStone = PlayerPrefs.GetInt("Water");
          waterStone += 1;
          PlayerPrefs.SetInt("Water", waterStone);
          PlayerPrefs.Save();
        }
    
    }

    public void BuyElectricStone () {

        currency = PlayerPrefs.GetInt("Currency");
        if (currency >= stonePrice) {
          currency -= stonePrice;
          PlayerPrefs.SetInt("Currency", currency);
          electricStone = PlayerPrefs.GetInt("Electric");
          electricStone += 1;
          PlayerPrefs.SetInt("Electric", electricStone);
          PlayerPrefs.Save();
        }
        
    }

    public void BuyFireStone () {

        currency = PlayerPrefs.GetInt("Currency");
        if (currency >= stonePrice) {
          currency -= stonePrice;
          PlayerPrefs.SetInt("Currency", currency);
          fireStone = PlayerPrefs.GetInt("Fire");
          fireStone += 1;
          PlayerPrefs.SetInt("Fire", fireStone);
          PlayerPrefs.Save();
        }
        
    }

}
