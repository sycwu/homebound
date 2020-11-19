using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Contains bit masks representing regions that an item restricts. */
public class ItemRegion : MonoBehaviour
{
    public const int TOP         = 0b00000001;
    public const int BOTTOM      = 0b00000010;
    public const int JEWELRY     = 0b00000100;
    public const int LEFT_EYE    = 0b00001000;
    public const int RIGHT_EYE   = 0b00010000;
    public const int HAIR        = 0b00100000;
    public const int NOSE        = 0b01000000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
