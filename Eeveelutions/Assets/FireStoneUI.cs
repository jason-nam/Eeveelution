using UnityEngine;
using UnityEngine.UI;

public class FireStoneUI : MonoBehaviour
{
    public Text fireText;
    [SerializeField] private DataSO fireStoneSO;



    void Start ()
    {
        fireText.text = "Fire Stone: " + fireStoneSO.Value.ToString();


    }

    void Update()
    {
        fireText.text = "Fire Stone: " + fireStoneSO.Value.ToString();



    }
}
