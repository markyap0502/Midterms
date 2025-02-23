using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
    public Spawner spawner;
    public GameObject egg;
    public Transform layHere;

    //starts 30 second timer for hen to lay eggs and 40 second timer for the hen's lifespan
    void Start()
    {
        spawner = GameObject.FindObjectOfType<Spawner>();
        Invoke("LayEgg", 30f);
        Destroy(gameObject, 40f);
    }

    // Update is called once per frame
    private void OnDestroy()
    {
        spawner.henCount--;
    }

    //gets a random number between 2, 10 and lays that many eggs
    void LayEgg()
    {
        int laynum = Random.Range(2, 10);
        for (int i = 0; i < laynum; i++)
        {
            Instantiate(egg, layHere.position, Quaternion.identity);
            spawner.eggCount++;
        }
        
    }
}

