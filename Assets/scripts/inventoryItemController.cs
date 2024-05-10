using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryItemController : MonoBehaviour
{
    item _item;
    public Button removeButton;

    public void removeItem()
    {
        inventoryManager.Instance.Remove(_item);
        Destroy(gameObject);

    }
    public void Additem(item newItem)
    {
        _item=newItem;
    }
    
}