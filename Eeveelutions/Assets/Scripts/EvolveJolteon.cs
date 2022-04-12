using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvolveJolteon : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;
    public int electric;
    public string state;
    // Start is called before the first frame update
    void Start()
    {
      electric = PlayerPrefs.GetInt("Electric");
      state = PlayerPrefs.GetString("State");
      if (state == "Electric")
      {
        original.sprite = newSprite;
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NewImage()
    {
      electric = PlayerPrefs.GetInt("Electric");
      if (electric > 0)
      {
        electric -= 1;
        PlayerPrefs.SetInt("Electric", electric);
        original.sprite = newSprite;
        state = "Electric";
        PlayerPrefs.SetString("State", state);
        PlayerPrefs.Save();

      }

    }
}
