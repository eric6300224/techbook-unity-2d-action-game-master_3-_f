using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManuManager : MonoBehaviour
{
    private void Awake()
    {
        //GameManager.Live = 3;
    }

    public void Start_Game()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void Quit_Game()
    {
        Application.Quit();
    }


    private void Update()
    {
        
    }
}
