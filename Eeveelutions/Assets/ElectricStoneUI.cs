using UnityEngine;
using UnityEngine.UI;

public class ElectricStoneUI : MonoBehaviour
{
    public Text electricText;
    [SerializeField] private DataSO electricStoneSO;



    void Start ()
    {
        electricText.text = "Electric Stone: " + electricStoneSO.Value.ToString();


    }

    void Update()
    {
        electricText.text = "Electric Stone: " + electricStoneSO.Value.ToString();



    }
}
