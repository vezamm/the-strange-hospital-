using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPickup : MonoBehaviour
{
    public item item;

    void Pickup()
    {
        manager.Instance.AddItem(item); // Changed from Add to AddItem
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Pickup();
    }
}
