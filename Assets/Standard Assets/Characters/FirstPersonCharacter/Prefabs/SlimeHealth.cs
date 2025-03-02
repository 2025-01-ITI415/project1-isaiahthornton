using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class slimeHealth : MonoBehaviour
{
    public int slimeHP, damage, slimesKilled;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamageSlime(int damage){
        slimeHP -= damage;

        if(slimeHP <= 0){
            Destroy(gameObject);
            UI.instance.slimesKilled++;
            Update();
        }
    }
}
