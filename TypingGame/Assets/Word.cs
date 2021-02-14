using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int typeIndex;
    private WordDisplay display;
    public Word(string word, WordDisplay display)
    {
        this.word = word;
        this.display = display;
        typeIndex = 0;
        this.display.SetWord(this.word);
    }
    public char GetNextLetter()
    {
        return word[typeIndex];
    }
    
    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();
    }
    public bool WordTyped()
    {
        bool typed = (typeIndex >= word.Length);
        //if (transform.position.y <= -5.1)
        //{
        //    wordManager.words.Remove(thisWord);
        //    RemoveWord();
        //}
        
        if (typed)
        {
            display.RemoveWord();
        }
        //UnityEngine.Debug.Log(y);
        
        return typed;
    }
    public bool OffScreen()
    {
        float y = display.transform.position.y;
        bool typed = (typeIndex >= word.Length);
        bool offScreen = (y <= -5.2 && !typed);
        if (offScreen)
        {
            display.RemoveWord();
        }
        return offScreen;
    }
}
