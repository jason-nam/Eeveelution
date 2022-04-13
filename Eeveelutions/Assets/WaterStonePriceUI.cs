using UnityEngine;
using UnityEngine.UI;

public class WaterStonePriceUI : MonoBehaviour
{
    public Text waterStonePrice;
    [SerializeField] private PriceSO waterStonePriceSO;

    void Start()
    {
        waterStonePrice.text = "$" + waterStonePriceSO.Value.ToString();
        waterStonePrice.color = new Color(0.0f, 0.39f, 0.0f, 1f);
    }

}
