using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator spriteanim;
    public float moveSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            spriteanim.SetBool("IsWalking", true);
        }
        else if (Input.GetKey(KeyCode.A)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            spriteanim.SetBool("IsWalking", true);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            spriteanim.SetBool("IsWalking", false);
        }
    }
}
