using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chasePlayer : MonoBehaviour
{
    public GameObject player;
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FPSController");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed*Time.deltaTime);
    }
    // This method gets called when the slime collides with the player
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy the slime on collision with the player
            Destroy(gameObject);
        }
    }
}
