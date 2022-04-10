using UnityEngine;
using UnityEngine.UI;

public class FireStonePriceUI : MonoBehaviour
{
    public Text fireStonePrice;
    [SerializeField] private PriceSO fireStonePriceSO;

    void Start()
    {
        fireStonePrice.text = "$" + fireStonePriceSO.Value.ToString();
    }

}
