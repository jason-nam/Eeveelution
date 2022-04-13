using UnityEngine;
using UnityEngine.UI;

public class FeedButtonController : MonoBehaviour {
    
    private float timer = 0.0f;
    private int food;
    private int health;
    private int dead;

    public void Start () {

        timer = 0.0f;
        food = 0;
        food = PlayerPrefs.GetInt("Food");
        health = 10;
        health = PlayerPrefs.GetInt("Health");
        dead = 0;
        dead = PlayerPrefs.GetInt("Dead");

    }

    public void FeedEevee () {

        dead = PlayerPrefs.GetInt("Dead");
        if (dead == 0) {
            food = PlayerPrefs.GetInt("Food");
            health = PlayerPrefs.GetInt("Health");
            if (food > 0 && health < 10) {
                food -= 1;
                PlayerPrefs.SetInt("Food", food);
                health += 5;
                PlayerPrefs.SetInt("Health", health);
                PlayerPrefs.Save();
            }
            timer = 0;
        }
    }

}
