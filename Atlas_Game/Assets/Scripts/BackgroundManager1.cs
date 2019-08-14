using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager1 : MonoBehaviour
{
    public GameObject rightBackPrefab;
    public GameObject firstBackground;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            SpawnBack();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBack()
    {
        firstBackground = (GameObject)Instantiate(rightBackPrefab, firstBackground.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
    }
}
