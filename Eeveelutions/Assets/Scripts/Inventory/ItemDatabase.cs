using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour{
    public List<Item> items = new List<Item>();

    private void Awake(){
        BuildDatabase();
    }

    void BuildDatabase(){
        Item eg = new Item(0, "emerald", "Sample", new Dictionary<string, int>{
                {"Food", 10}
                });
        items.Add(eg);
    }

    public Item GetItem(int id){
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName){
        return items.Find(item => item.title == itemName);
    }



}
