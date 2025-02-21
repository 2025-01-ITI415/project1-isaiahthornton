using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chasePlayer : MonoBehaviour
{
    public GameObject player;
    public float speed = 1;
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
}
