using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryState : MonoBehaviour
{
    /* Map of item IDs to counts. */
    //TODO: write a comparator to sort by item ID
    SortedDictionary<Item, int> itemCounts = new SortedDictionary<Item, int>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Adds an item to the inventory. */
    public void addItem(Item item)
    {
        itemCounts[item] += 1;
    }

    /* Removes an item from the inventory. Returns false if item is not
     * in inventory. */
    public bool removeItem(Item item)
    {
        if (itemCounts[item] == 0)
        {
            return false;
        }

        itemCounts[item] -= 1;
        return true;
    }
}
