using UnityEngine;

public class DoorScript : MonoBehaviour, ICollectableItem
{
    public KeyScriptableObject keyScriptableObject;

    [SerializeField] private int howManyKeysDoDoorsNeed;
 

     
       public void Collect() {
            if (keyScriptableObject.Keys.Count == howManyKeysDoDoorsNeed) {
                Destroy(this.gameObject);   


            }    



        }
    }
    
 
