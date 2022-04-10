using UnityEngine;
using UnityEngine.UI;

public class FoodPriceUI : MonoBehaviour
{
    public Text foodPrice;
    [SerializeField] PriceSO foodPriceSO;

    void Start()
    {
        foodPrice.text = "$" + foodPriceSO.Value.ToString();
    }

}
