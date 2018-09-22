using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    Image healthbar;
    float maxhealth = 100f;
    public static float health;
	
	void Start () {
        healthbar = GetComponent<Image>();
        health = maxhealth;
	}
	
	
	void Update () {
        healthbar.fillAmount = health / maxhealth;
	}
}
