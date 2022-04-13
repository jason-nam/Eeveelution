using UnityEngine;
using UnityEngine.UI;

public class ElectricStonePriceUI : MonoBehaviour
{
    public Text electricStonePrice;
    [SerializeField] private PriceSO electricStonePriceSO;

    void Start()
    {
        electricStonePrice.text = electricStonePriceSO.Value.ToString();
        electricStonePrice.color = new Color(245/255.0f, 222/255.0f, 3/255.0f, 1f);
    }

}
