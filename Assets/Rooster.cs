using UnityEngine;

public class Rooster : MonoBehaviour
{
    public Spawner spawner;

    void Start()
    {
        spawner = GameObject.FindObjectOfType<Spawner>();
        Destroy(gameObject, 40f);
    }

    private void OnDestroy()
    {
        spawner.roosterCount--;
    }
}
