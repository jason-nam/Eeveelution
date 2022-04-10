using UnityEngine;
using UnityEngine.UI;

public class ElectricStonePriceUI : MonoBehaviour
{
    public Text electricStonePrice;
    [SerializeField] private PriceSO electricStonePriceSO;

    void Start()
    {
        electricStonePrice.text = "$" + electricStonePriceSO.Value.ToString();
    }

}
