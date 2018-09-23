using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public MainMenu menu;

    private void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            Debug.Log("WinningScene");
            menu.WinningScene();
        }
    }
}