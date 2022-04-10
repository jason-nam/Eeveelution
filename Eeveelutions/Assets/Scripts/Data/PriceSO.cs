using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class PriceSO : ScriptableObject
{
    [SerializeField] private int _price;

    public int Value
    {
        get { return _price; }
        set { _price = value; }
    }

}
