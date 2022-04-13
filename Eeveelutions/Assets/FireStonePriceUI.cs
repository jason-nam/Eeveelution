using UnityEngine;
using UnityEngine.UI;

public class FireStonePriceUI : MonoBehaviour
{
    public Text fireStonePrice;
    [SerializeField] private PriceSO fireStonePriceSO;

    void Start()
    {
        fireStonePrice.text = fireStonePriceSO.Value.ToString();
        fireStonePrice.color = new Color(245/255.0f, 222/255.0f, 3/255.0f, 1f);
    }

}
