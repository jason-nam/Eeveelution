using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedButtonScript : MonoBehaviour
{

    int health = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown ()
    {
        if (health < 10) health = health + 1;
        Debug.Log("Health: " + health);
    }

}
