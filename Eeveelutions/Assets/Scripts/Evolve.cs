using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evolve : MonoBehaviour {

    public Image current;
    public Sprite jolteon;
    public Sprite joltSad;
    public Sprite joltDead;
    public Sprite flareon;
    public Sprite flareSad;
    public Sprite flareDead;
    public Sprite vaporeon;
    public Sprite vaporSad;
    public Sprite vaporDead;
    public Sprite eevee;
    public Sprite eeveeSad;
    public Sprite eeveeDead;
    public int electric;
    public int fire;
    public int water;
    public string state;
    public int health;
    public int dead;
    
    // Start is called before the first frame update
    void Start() {
        
        dead = PlayerPrefs.GetInt("Dead");
        if (dead == 0) {
            electric = PlayerPrefs.GetInt("Electric");
            fire = PlayerPrefs.GetInt("Fire");
            water = PlayerPrefs.GetInt("Water");
            state = PlayerPrefs.GetString("State");
            health = PlayerPrefs.GetInt("Health");
            if (health > 3) {
                if (state == "Electric") {
                    current.sprite = jolteon;
                } else if (state == "Fire") {
                    current.sprite = flareon;
                } else if (state == "Water") {
                    current.sprite = vaporeon;
                } else {
                    current.sprite = eevee;
                }
            } else if (health > 0) {
                if (state == "Electric") {
                    current.sprite = joltSad;
                } else if (state == "Fire") {
                    current.sprite = flareSad;
                } else if (state == "Water") {
                    current.sprite = vaporSad;
                } else {
                    current.sprite = eeveeSad;
                }
            } else {
                if (state == "Electric") {
                    current.sprite = joltDead;
                } else if (state == "Fire") {
                    current.sprite = flareDead;
                } else if (state == "Water") {
                    current.sprite = vaporDead;
                } else {
                    current.sprite = eeveeDead;
                }
                dead = 1;
                PlayerPrefs.SetInt("Dead", dead);
                PlayerPrefs.Save();
            } 
        } else {
            if (state == "Electric") {
                current.sprite = joltDead;
            } else if (state == "Fire") {
                current.sprite = flareDead;
            } else if (state == "Water") {
                current.sprite = vaporDead;
            } else {
                current.sprite = eeveeDead;
            }
        }



    } 

    public void Jolteon() {
        
        electric = PlayerPrefs.GetInt("Electric");
        state = PlayerPrefs.GetString("State");
        if (electric > 0 && state == "Eevee") {
            electric -= 1;
            PlayerPrefs.SetInt("Electric", electric);
            current.sprite = jolteon;
            state = "Electric";
            PlayerPrefs.SetString("State", state);
            PlayerPrefs.Save();
        }

    }

    public void Flareon() {
        
        fire = PlayerPrefs.GetInt("Fire");
        state = PlayerPrefs.GetString("State");
        if (fire > 0 && state == "Eevee") {
            fire -= 1;
            PlayerPrefs.SetInt("Fire", fire);
            current.sprite = flareon;
            state = "Fire";
            PlayerPrefs.SetString("State", state);
            PlayerPrefs.Save();
        }

    }

    public void Vaporeon() {
        
        water = PlayerPrefs.GetInt("Water");
        state = PlayerPrefs.GetString("State");
        if (water > 0 && state == "Eevee") {
            water -= 1;
            PlayerPrefs.SetInt("Water", water);
            current.sprite = vaporeon;
            state = "Water";
            PlayerPrefs.SetString("State", state);
            PlayerPrefs.Save();
        }

    }

}
