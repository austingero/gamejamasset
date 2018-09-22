using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D body;
    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float Speed = 10;

    void Start() {
        body = GetComponent<Rigidbody2D>();
    }


    void Update() {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

    }
    void FixedUpdate()
    {
        if (horizontal ! = 0 && vertical ! = 0)
            body.velocity = new Vector2((horizontal * Speed) * moveLimiter, (vertical * Speed) * moveLimiter);
        else
        body.velocity = new Vector2(horizontal * Speed, vertical * Speed);
    }

}



