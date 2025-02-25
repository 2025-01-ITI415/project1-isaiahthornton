using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRate : MonoBehaviour
{
    public GameObject slimePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnSlime", 2);
        Invoke("SpawnSlime2", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnSlime(){
        Instantiate(slimePrefab);
        Invoke("SpawnSlime", 5);
    }
     public void SpawnSlime2(){
        Instantiate(slimePrefab);
        Invoke("SpawnSlime2", 5);
    }
}
