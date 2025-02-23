using NUnit.Framework.Constraints;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public Spawner spawner;
    public GameObject chick;
    public Transform hatchhere;

    //starts 10 second timer for egg to hatch to chick
    void Start()
    {
        spawner = GameObject.FindObjectOfType<Spawner>();
        Destroy(gameObject, 10f);
    }

    //destroys egg and spawns chick
    public void OnDestroy()
    { 
        spawner.eggCount--;
        Instantiate(chick, hatchhere.position, Quaternion.identity);
        spawner.chickCount++;
    }

}
