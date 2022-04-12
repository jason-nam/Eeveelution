using UnityEngine;
using UnityEngine.UI;

public class CurrencyUI : MonoBehaviour
{
    public Text currencyText;
    [SerializeField] private DataSO healthSO;
    [SerializeField] private DataSO currencySO;
    private float timer = 0.0f;
    
    void Start()
    {
        currencyText.text = "$" + currencySO.Value.ToString();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
            if (healthSO.Value > 0)
            {
                currencySO.Value += 10;
                currencyText.text = "$" + currencySO.Value.ToString();
                timer = 0;
            }
    }
}
