﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager;
    public float wordDelay = 2.0f;
    private float nextWordTime = 0f;
    // Update is called once per frame
    void Update()
    {
       
            if (Time.time >= nextWordTime)
            {
                wordManager.AddWord();
                nextWordTime = Time.time + wordDelay;
                wordDelay *= .99f;
            }
        
    }

    //void Start()
    //{
    //    wordManager.AddWord();

    //}
}
