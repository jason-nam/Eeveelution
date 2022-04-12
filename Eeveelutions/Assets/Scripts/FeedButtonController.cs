using UnityEngine;
using UnityEngine.UI;

public class FeedButtonController : MonoBehaviour {
    
    private float timer = 0.0f;
    private int food;
    private int health;

    public void Start () {

        timer = 0.0f;
        food = 0;
        food = PlayerPrefs.GetInt("Food");
        health = 10;
        health = PlayerPrefs.GetInt("Health");

    }

    public void FeedEevee () {

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

    public void Update () {
        timer += Time.deltaTime;
        if (timer > 3) {
            health = PlayerPrefs.GetInt("Health");
            if (health > 0) {
                health -= 1;
                PlayerPrefs.SetInt("Health", health);
                timer = 0;
                PlayerPrefs.Save();
            }
        }    
    }

}
