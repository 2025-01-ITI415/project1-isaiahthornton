using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeHealth : MonoBehaviour
{
    public int currentHealth;  // Health of the slime

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamageSlime(int damage){
        currentHealth -= damage;

        if(currentHealth <= 0){
            Destroy(gameObject);
        }
    }
}
