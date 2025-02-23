using UnityEngine;
using TMPro;
using UnityEngine.VFX;

public class Spawner : MonoBehaviour
{
    public int eggCount, chickCount, henCount, roosterCount;
    public TextMeshProUGUI eggCountText, chickCountText, henCountText, roosterCountText;
    public GameObject egg;
    public Transform spawnHere;

    //spawns first egg
    void Start()
    {
        Instantiate(egg, spawnHere.position, Quaternion.identity);
        eggCount++;
    }

    // Updates the number of eggs, chicks, hens, and roosters.
    void Update()
    {
        eggCountText.text = eggCount.ToString();
        chickCountText.text = chickCount.ToString();
        henCountText.text = henCount.ToString();
        roosterCountText.text = roosterCount.ToString();
    }

}
