using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WordManager wordManager;
    void Update()
    {
        string inputString = UnityEngine.Input.inputString;
        foreach(char letter in inputString)
        {
            //Debug.Log(letter);
            //UnityEngine.Debug.Log(letter);
            wordManager.TypeWord(letter);
        }
    }
}
