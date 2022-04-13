using UnityEngine;
using UnityEngine.UI;

public class WaterStonePriceUI : MonoBehaviour
{
    public Text waterStonePrice;
    [SerializeField] private PriceSO waterStonePriceSO;

    void Start()
    {
        waterStonePrice.text = waterStonePriceSO.Value.ToString();
        waterStonePrice.color = new Color(245/255.0f, 222/255.0f, 3/255.0f, 1f);
    }

}
