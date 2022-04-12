using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderButtonUI : MonoBehaviour
{

    [SerializeField] private string leaderView = "LeaderboardView";

    public void LeaderButton ()
    {
        SceneManager.LoadScene(leaderView);
    }

}
