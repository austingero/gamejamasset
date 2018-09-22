using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D body;
    Animator Character;
    SpriteRenderer Movement;
    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float Speed = 10;

    void Start() {
        body = GetComponent<Rigidbody2D>();
        Character = GetComponent<Animator>();
        Movement = GetComponent<SpriteRenderer>();
    }


    void Update() {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Character.SetFloat("Speed", vertical);

    }
    
    
    void FixedUpdate()
    {
        /* if (horizontal ! = 0 && vertical ! = 0)
             body.velocity = new Vector2((horizontal * Speed) * moveLimiter, (vertical * Speed) * moveLimiter);
         else
         body.velocity = new Vector2(horizontal * Speed, vertical * Speed);*/

        body.AddForce(new Vector2(((horizontal * Speed) - body.velocity.x) * moveLimiter, ((vertical * Speed) - body.velocity.y) * moveLimiter));
    }

}



