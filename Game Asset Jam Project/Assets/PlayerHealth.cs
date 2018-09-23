using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float MaxHealth = 100f;
    public float health;
    public Image Foreground;
    public MainMenu menu;
    // Use this for initialization

    float healthTimer = 0.0f;
    bool RegainHealth = false;
    public GameObject Healthpickup;
    void Start()
    {
        health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Player Health = " + health);

        Foreground.fillAmount = health / MaxHealth;
        if (health <= 0)
        {
            Debug.Log("Game Over");
            menu.WinningScene();
        }

        if (RegainHealth)
        {
            healthTimer += Time.deltaTime;
            if (healthTimer > 4.0f)
            {
                Healthpickup.gameObject.SetActive(true);
                healthTimer = 0.0f;
            }
        }
    }
    private void OnTriggerEnter(Collider healthpack)
    {
        if (healthpack.gameObject.tag == "HealthPack")
        {
            if (health < 100)
            {
                health = MaxHealth + 5;
                healthpack.gameObject.SetActive(false);
                RegainHealth = true;
            }
        }
    }
}
