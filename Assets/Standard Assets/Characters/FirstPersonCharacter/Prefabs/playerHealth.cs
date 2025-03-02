using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int totalHealth = 5;  // Total hearts (player health)
    private int currentHealth;   // Current health (tracking current hearts)
    private float lastHitTime = 0f;  // Timestamp of last hit
    public float damageCooldown = 2f;  // Time before the player can be damaged again (2-second cooldown)
    private SpriteRenderer playerRenderer; // Reference to the player's sprite renderer for red tint effect

    void Start()
    {
        currentHealth = totalHealth;  // Initialize health to total health
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Slime") && Time.time - lastHitTime >= damageCooldown)
        {
            TakeDamage(1);  // The player takes 1 damage when colliding with a slime
            lastHitTime = Time.time;  // Update the timestamp for the last hit
        }
    }

    void TakeDamage(int amount)
    {
        currentHealth -= 1;  // Decrease health by the amount of damage taken
        if (currentHealth <= 0)
        {
            Die();  // If health reaches 0, trigger death
        }
    }

    void Die()
    {
        // Handle player death 
        Debug.Log("Player is dead!");
        // For example, restart the scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}