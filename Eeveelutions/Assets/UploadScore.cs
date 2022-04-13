using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UploadScore : MonoBehaviour
{   
    
    
    public void Upload()
    {
        Leaderboard.leaders.Add(new Leader(PlayerPrefs.GetString("Username"), PlayerPrefs.GetInt("Currency"));
        Leaderboard.leaders.Sort();
    }
}
