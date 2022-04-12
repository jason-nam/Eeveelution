using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item{
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(int id, string title, string description, Dictionary<string, int> stats){
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + title);
        this.stats = stats;
    }

    public Item(Item otherItem){
        this.id = otherItem.id;
        this.title = otherItem.title;
        this.description = otherItem.description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + otherItem.title);
        this.stats = otherItem.stats;
    }
}
