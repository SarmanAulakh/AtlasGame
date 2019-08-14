﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    public GameObject rightTilePrefab;
    public GameObject firstTile;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 50; i++)
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

       /* int hempPickup = Random.Range(0, 10); //range between 0 and 9

        if(hempPickup == 0)
        {
            firstTile.transform.GetChild(1).gameObject.SetActive(true);
        }
        */
    }
}