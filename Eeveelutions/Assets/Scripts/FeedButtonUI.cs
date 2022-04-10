using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedButtonUI : MonoBehaviour
{
    int health = 0;
    // public HealthText healthText;

    public void FeedEevee ()
    {
        health = health + 1;
        // healthText.text = health.ToString();
    }

}
