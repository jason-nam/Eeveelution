using UnityEngine;
using UnityEngine.UI;

public class ElectricStonePriceUI : MonoBehaviour
{
    public Text electricStonePrice;
    [SerializeField] private PriceSO electricStonePriceSO;

    void Start()
    {
        electricStonePrice.text = "$" + electricStonePriceSO.Value.ToString();
        electricStonePrice.color = new Color(0.0f, 0.39f, 0.0f, 1f);
    }

}
