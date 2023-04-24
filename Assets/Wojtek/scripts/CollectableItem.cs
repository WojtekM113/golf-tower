using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 
public enum ItemType {KEY, COINS }

[CreateAssetMenu]
public class CollectableItem : ScriptableObject {
    new public string name = "New Item";
    public Sprite icon;
    public ItemType type;



}
 

