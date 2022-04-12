using UnityEngine;
using UnityEngine.UI;

public class TransactionUI : MonoBehaviour
{
    [SerializeField] private DataSO currencySO;
    [SerializeField] private DataSO foodSO;
    [SerializeField] private PriceSO foodPriceSO;
    [SerializeField] private PriceSO waterStonePriceSO;
    [SerializeField] private PriceSO electricStonePriceSO;
    [SerializeField] private PriceSO fireStonePriceSO;
    [SerializeField] private DataSO WaterStoneSO;
    [SerializeField] private DataSO FireStoneSO;
    [SerializeField] private DataSO ElectricStoneSO;


    public void BuyFood ()
    {
        if (currencySO.Value >= foodPriceSO.Value)
        {
            currencySO.Value -= foodPriceSO.Value;
            foodSO.Value += 1;
        }
    }

    public void BuyWaterStone ()
    {
        if (currencySO.Value >= waterStonePriceSO.Value)
        {
          currencySO.Value -= waterStonePriceSO.Value;
          WaterStoneSO.Value += 1;
        }
        // Update inventory
    }

    public void BuyElectricStone ()
    {
        if (currencySO.Value >= electricStonePriceSO.Value)
        {
          currencySO.Value -= electricStonePriceSO.Value;
          ElectricStoneSO.Value += 1;
        }
        // Update inventory
    }

    public void BuyFireStone ()
    {
        if (currencySO.Value >= fireStonePriceSO.Value)
        {
          currencySO.Value -= fireStonePriceSO.Value;
          FireStoneSO.Value += 1;
        }
        // Update inventory
    }

}
