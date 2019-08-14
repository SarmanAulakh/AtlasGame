using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject lightning;
    public GameObject cloud;
    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.

        for(int i = 0; i < 5; i++)
        {
            Instantiate(lightning, new Vector3(0 + (10*i), 0, 0), Quaternion.identity);
            Instantiate(lightning, new Vector3((float)0.5 + (10 * i), 0, 0), Quaternion.identity);
            Instantiate(lightning, new Vector3(1 + (10 * i), 0, 0), Quaternion.identity);
            Instantiate(cloud, new Vector3((float)6.2 + (10 * i), (float)3.4, 0), Quaternion.identity);

        }
    }
}
