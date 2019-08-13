using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_test1 : MonoBehaviour
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


        if (Input.GetKeyDown("q") && audioScript.sickoMode == false)
        {
            audioScript.StopSound();
            audioScript.SickoMode();
        }
        else if(Input.GetKeyDown("q") && audioScript.sickoMode == true)
        {
            audioScript.StopSickoMode();
            audioScript.PlaySound();
        }


    }
}