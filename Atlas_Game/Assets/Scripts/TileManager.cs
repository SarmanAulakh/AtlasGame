using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    public GameObject rightTilePrefab;
    public GameObject firstTile;
    private uint startNum = 0;
    private uint endNum = 15;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 500; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void SpawnTile()
    {
        firstTile = (GameObject) Instantiate(rightTilePrefab, firstTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);

        int hempPickup = Random.Range(0, 15); //range between 0 and 14
        if(startNum > endNum)
        {
            if (hempPickup == 0)
            {
                firstTile.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
            }
            else if(hempPickup == 1 || hempPickup == 5 || hempPickup == 10)
            {
                firstTile.transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(true);
            }
        }
        startNum++;
    }
}
