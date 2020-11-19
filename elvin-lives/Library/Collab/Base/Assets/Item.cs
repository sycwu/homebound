using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    /* Bitstring representing regions restricted by item.  */
    const int restrictedRegions;

    /* Whether item is a material. */
    const bool isMaterial;

    /* Item ID. */
    const int id; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Returns whether item restricts given region. */
    bool restrictsRegion(int region) 
    {
        return ( restrictedRegions & region ) == region;
    }
}
