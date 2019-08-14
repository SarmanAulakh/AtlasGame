using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public static Main S;
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

        if (Input.GetKeyDown("r"))
        {
            Debug.Log("Gm");
            GameOver();
        }
            

    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene("Menu");
    }
}