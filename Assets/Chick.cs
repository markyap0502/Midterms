using UnityEngine;

public class Chick : MonoBehaviour
{
    public Spawner spawner;
    public GameObject[] matureTo;
    public Transform matureHere;
    void Start()
    {
        //starts the 10 second timer for the chick to mature
        spawner = GameObject.FindObjectOfType<Spawner>();
        Destroy(gameObject, 10f);
    }

    public void OnDestroy()
    {
        //if there is only one chick, then it automatically matures to a hen
        if (spawner.chickCount == 1)
        {
            Instantiate(matureTo[0], matureHere.position, Quaternion.identity);
            spawner.henCount++;
        }
        //if there are more than one chick, then it randomly matures to a hen or a rooster
        else
        {
            int rand = Random.Range(0, matureTo.Length);
            Instantiate(matureTo[rand], matureHere.position, Quaternion.identity);
            if (rand == 0)
            {
                spawner.henCount++;
            }
            else
            {
                spawner.roosterCount++;
            }
        }
        spawner.chickCount--;
    }
}
