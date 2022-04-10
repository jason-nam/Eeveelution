using UnityEngine;
using UnityEngine.UI;

public class ShopCurrencyUI : MonoBehaviour
{
    public Text currencyText;
    [SerializeField] private DataSO currencySO;

    void Update()
    {
        currencyText.text = "$" + currencySO.Value.ToString();
    }
}
