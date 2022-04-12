using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour{
    public List<Item> items = new List<Item>();

    private void Awake(){
        BuildDatabase();
    }

    void BuildDatabase(){
        Item electricStone = new Item(0, "electricStone", "Electric Stone", null);
        Item waterStone = new Item(1, "waterStone", "Water Stone", null);
        Item fireStone = new Item(2, "fireStone", "Fire Stone", null);
        Item food = new Item(3, "food", "Food", null);
        items.Add(electricStone);
        items.Add(waterStone);
        items.Add(fireStone);
        items.Add(food);
    }

    public Item GetItem(int id){
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName){
        return items.Find(item => item.title == itemName);
    }



}
