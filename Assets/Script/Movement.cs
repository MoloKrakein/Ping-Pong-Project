using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    public bool isPlayer1;
    public float speed = 10f;
    public Rigidbody2D rb;

    private float movement;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(isPlayer1){
            movement = Input.GetAxisRaw("Vertical1");
        }else{
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
