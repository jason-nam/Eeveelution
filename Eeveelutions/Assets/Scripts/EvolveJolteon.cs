using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvolveJolteon : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;

    [SerializeField] private DataSO ElectricStoneSO;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NewImage()
    {
      if (ElectricStoneSO.Value > 0)
      {
        original.sprite = newSprite;
        ElectricStoneSO.Value -= 1;
      }

    }
}
