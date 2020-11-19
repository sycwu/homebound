using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void destroyObject()
    {
        Destroy(gameObject);
    }

    //void OnTriggerEnter2D(Collider2D other) {
    //    Debug.Log("collied with SOMETHING");
    //    if (other.tag == "Player")
    //    {
    //        Debug.Log("collided wiht player");
    //        Destroy(gameObject);
    //    }
    //}
}
