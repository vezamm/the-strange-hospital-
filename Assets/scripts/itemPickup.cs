using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPickup : MonoBehaviour
{
    public item item;

    public void Pickup()
    {
        manager.Instance.ADD(item); // Changed from Add to AddItem
        Destroy(gameObject);
    }




   private void OnMouseDown()
   {
       Pickup();
   }
}
