using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{

    /* Map of (region -> item in region). Value is null if not item is in specified
     * region */
    Dictionary<int, Item> activeItems;

    /* Map (item -> selected dynamic restricted region), if applicable. */ 
    Dictionary<Item, int> dynamicRestrictedRegions;

    /* Inventory */
    InventoryState inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Wears item. Places removed item in inventory. */
    public void WearItem(Item item)
    {
        foreach (int region in item.GetRestrictedRegions())
        {
            addItemHelper(item, region);
        }
    }
    
    /* Wears item. Worn item restricts additional regions specified by
     * RESTRICTEDREGIONS. */
    public void WearItem(Item item, int restrictedRegions)
    {
        WearItem(item);
        dynamicRestrictedRegions[item] = restrictedRegions;

        foreach (int region in item.GetRestrictedRegions(restrictedRegions))
        {
            addItemHelper(item, region);
        }
    }

    /* Removes item occupying REGION and places item in inventory. */
    public void RemoveItem(int region)
    {
        Item explicitRemovedItem = activeItems[region];
        int restrictedRegions = explicitRemovedItem.staticRestrictedRegions;

        if (dynamicRestrictedRegions.ContainsKey(explicitRemovedItem))
        {
            restrictedRegions |= dynamicRestrictedRegions[explicitRemovedItem];
            dynamicRestrictedRegions.Remove(explicitRemovedItem);
        }

        foreach (int implicitRegion 
                 in explicitRemovedItem.GetRestrictedRegions(restrictedRegions))
        {
            removeItemHelper(implicitRegion);
        }
    }

    private void addItemHelper(Item item, int region)
    {
        Item replacedItem = activeItems[region];
        inventory.addItem(replacedItem);

        activeItems[region] = item;
        inventory.removeItem(item);
    }

    private void removeItemHelper(int region) {
        Item item = activeItems[region];
        activeItems[region] = null;
        inventory.addItem(item);
    }
}
