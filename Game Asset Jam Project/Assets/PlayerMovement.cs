using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D rb2d;
    Animator Character;
    SpriteRenderer Movement;
    public float speed;
    public float MaxSpeed;
    public class PlayerStats
    {
        public int HealthAmount = 100;
    }
    public PlayerStats playerStats = new PlayerStats();

    public void DamagePlayer(int amount)
    {
        playerStats.HealthAmount -= amount;
        if (playerStats.HealthAmount <= 0)
        {
            PlayerMA.EliminateChef(this);
        }
    }
    private int ingredients;
    public Text countIngredients;
    public Text allGathered;


    // Use this for initialization
    void Start()
    {
        ingredients = 0;
        allGathered.text = " ";
        SetCountIngredients();
        rb2d = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        if(rb2d.velocity.magnitude < MaxSpeed)
        {
            rb2d.AddForce(movement * speed);
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            ingredients = ingredients + 1;
            SetCountIngredients();
        }
    }

    void SetCountIngredients()
    {
        countIngredients.text = "Ingredients: " + countIngredients.ToString();
        
        if(ingredients >= 3)
        {
            allGathered.text = " It is a Cheese Burger! Congradulations!";
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
