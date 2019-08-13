using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_test : MonoBehaviour
{
    public Audio audioScript;


    // Start is called before the first frame update
    void Start()
    {
        audioScript.PlaySound();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed");

        }


    }
}
