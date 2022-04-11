using UnityEngine;
using UnityEngine.UI;

public class FeedButtonController : MonoBehaviour
{
    public Text healthText;
    [SerializeField] private DataSO foodSO;
    [SerializeField] private DataSO healthSO;
    private float timer = 0.0f;

    public void Start ()
    {
        healthText.text = healthSO.Value.ToString();
    }

    public void FeedEevee ()
    {
        if (foodSO.Value > 0 && healthSO.Value < 10)
        {
            healthSO.Value += 1;
            foodSO.Value -= 1;
        }
        healthText.text = healthSO.Value.ToString();
        timer = 0;
    }

    public void Update ()
    {
        timer += Time.deltaTime;
        if (timer > 3)
            if (healthSO.Value > 0)
            {
                healthSO.Value -= 1;
                healthText.text = healthSO.Value.ToString();
                timer = 0;
            }
    }

}
