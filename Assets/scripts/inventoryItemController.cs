using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryItemController : MonoBehaviour
{
    item item;
    public Button removeButton;

    public void removeItem()
    {
        inventoryManager.Instance.Remove(item);
        Destroy(gameObject);

    }
    public void Additem(item newItem)
    {
        item=newItem;
    }
}