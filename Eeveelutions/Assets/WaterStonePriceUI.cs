using UnityEngine;
using UnityEngine.UI;

public class WaterStonePriceUI : MonoBehaviour
{
    public Text waterStonePrice;
    [SerializeField] private PriceSO waterStonePriceSO;

    void Start()
    {
        waterStonePrice.text = "$" + waterStonePriceSO.Value.ToString();
    }

}
