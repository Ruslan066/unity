﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lelels : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    public void LoadLvl1()
    {
        SceneManager.LoadScene("game");
    }
    public void LoadLvl2()
    {
        SceneManager.LoadScene("LvL2");
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("main");
    }
}
