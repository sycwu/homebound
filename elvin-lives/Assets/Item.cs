using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    /* Bitstring representing the group of regions restricted by item. */
    internal readonly int staticRestrictedRegions;

    /* Array of bitstrings, each represeting a group of regions a player can 
     * use to restricted when wearing an item. */
    internal readonly int[] dynamicRestrictedRegions;

    /* Whether item is a material. */
    readonly bool isMaterial;

    /* Item ID. */
    internal readonly int id; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Returns whether item restricts given region. */
    public bool RestrictsRegion(int region) 
    {
        return (staticRestrictedRegions & region) == region;
    }

    /* Returns an iterator that yields restricted regions. */
    public IEnumerable<int> GetRestrictedRegions()
    {
        return GetRestrictedRegions(staticRestrictedRegions);
    }

    public IEnumerable<int> GetRestrictedRegions(int restrictedRegions)
    {
        int rr = restrictedRegions;
        int testRegion = 0b1;

        while (rr != 0) 
        {
            if ((rr & 0b1) == 0b1)
            {
                yield return testRegion;
            }

            rr >>= 1;
            testRegion <<= 1;
        }
    }
}
