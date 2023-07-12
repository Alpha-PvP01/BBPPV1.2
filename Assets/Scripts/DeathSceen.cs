using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathSceen : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    public GameObject deathPanel;
    public GameObject player;
    
    void Start()
    {
        deathPanel.SetActive(false);
        playerHealth = GetComponent<Health>();
    }
    private void OnEnable()
    {
        playerHealth.death += LoadDeathScreen;
    }
    private void OnDisable()
    {
        playerHealth.death -= LoadDeathScreen;
    }
    private void LoadDeathScreen()
    {
        deathPanel.SetActive(true);
    }
    
    public void RespawnHero()
    {
        player.SetActive(true);
        playerHealth = player.GetComponent<Health>();
        player.GetComponent<Rigidbody2D>().position = new Vector2(-7.49f, -0.54f);
        playerHealth.SetHealth(playerHealth.maxHealth);
        deathPanel.SetActive(false);
    }
}
