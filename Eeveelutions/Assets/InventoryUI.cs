using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Text inventoryText;
    [SerializeField] private DataSO foodSO;



    void Start ()
    {
        inventoryText.text = "Food: " + foodSO.Value.ToString();


    }

    void Update()
    {
        inventoryText.text = "Food: " + foodSO.Value.ToString();



    }
}
