using UnityEngine;
using UnityEngine.UI;

public class WaterStoneUI : MonoBehaviour
{
    public Text waterText;
    [SerializeField] private DataSO waterStoneSO;



    void Start ()
    {
        waterText.text = "Food: " + waterStoneSO.Value.ToString();


    }

    void Update()
    {
        waterText.text = "Food: " + waterStoneSO.Value.ToString();



    }
}
