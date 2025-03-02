using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;

    public int maxHealth, currentHealth;  // Total hearts (player health)

    private void Awake(){
        instance = this;
    }
    
    void Start()
    {
        currentHealth = maxHealth;
        UI.instance.healthSlider.maxValue = maxHealth;
        UI.instance.healthSlider.value = currentHealth;
        UI.instance.healthText.text = "HEALTH: " + currentHealth +"/"+ maxHealth;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Slime"))
        {
            TakeDamage(1);  // The player takes 1 damage when colliding with a slime
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;  // Decrease health by the amount of damage taken
        if (currentHealth <= 0)
        {
            Die();  // If health reaches 0, trigger death
        }

        UI.instance.healthSlider.value = currentHealth;
        UI.instance.healthText.text = "HEALTH: " + currentHealth +"/"+ maxHealth;
    }

    void Die()
    {
        // Handle player death 
        Debug.Log("Player is dead!");
        // For example, restart the scene
        gameObject.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}