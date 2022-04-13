using UnityEngine;
using UnityEngine.UI;

public class FireStonePriceUI : MonoBehaviour
{
    public Text fireStonePrice;
    [SerializeField] private PriceSO fireStonePriceSO;

    void Start()
    {
        fireStonePrice.text = "$" + fireStonePriceSO.Value.ToString();
        fireStonePrice.color = new Color(0.0f, 0.39f, 0.0f, 1f);
    }

}
