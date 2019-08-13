using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public GameObject currentBackground;
    public GameObject backgroundPrefab;

    private static BackgroundManager instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnBackground()
    {

      //  currentBackground = Instantiate(backgroundPrefab, cur)
      //  currentTile = (GameObject)Instantiate(tilePrefabs[randIndex], currentTile.transform.GetChild(0).transform.GetChild(randIndex).position, Quaternion.identity);

        /*
        int spawnPickup = Random.Range(0, 10);

        if (spawnPickup == 0)
        {
            currentTile.transform.GetChild(1).gameObject.SetActive(true);
        }
        */
    }
}
