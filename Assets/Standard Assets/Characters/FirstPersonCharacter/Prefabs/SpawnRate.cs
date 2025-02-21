using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRate : MonoBehaviour
{
    public GameObject slime1Prefab;
    public GameObject slime2Prefab;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnSlime", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnSlime(){
        Instantiate(slime1Prefab);
        Invoke("SpawnSlime", 5);
    }
     public void SpawnSlime2(){
        Instantiate(slime2Prefab);
        Invoke("SpawnSlime", 5);
    }
}
