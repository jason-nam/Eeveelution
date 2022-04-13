using UnityEngine;
using UnityEngine.UI;

public class FoodPriceUI : MonoBehaviour
{
    public Text foodPrice;
    [SerializeField] PriceSO foodPriceSO;

    void Start()
    {
        foodPrice.text = "$" + foodPriceSO.Value.ToString();
        foodPrice.color = new Color(0.0f, 0.39f, 0.0f, 1f);
    }

}
