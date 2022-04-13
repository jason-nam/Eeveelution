using UnityEngine;
using UnityEngine.UI;

public class FoodPriceUI : MonoBehaviour
{
    public Text foodPrice;
    [SerializeField] PriceSO foodPriceSO;

    void Start()
    {
        foodPrice.text = foodPriceSO.Value.ToString();
        foodPrice.color = new Color(245/255.0f, 222/255.0f, 3/255.0f, 1f);
    }

}
