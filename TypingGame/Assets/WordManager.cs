using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour
{
    public List<Word> words;
    private bool hasActiveWord;
    private Word activeWord;
    public WordSpawner wordSpawner;
    public Text scoreText;
    public Text livesText;
    public Text highScoreText;
    private static int score = 0;
    private static int lives = 15;
    private int highScore;
    public void AddWord()
    {
        words.Add(new Word(WordGenerator.GetRandomWord(),wordSpawner.SpawnWord()));
    }
    void Start()
    {
        score = 0;
        lives = 15;
    }
    private void Update()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0); 
        for (int i = words.Count - 1; i >= 0; i--) {
            var word = words[i];
            bool isOff = word.OffScreen();
            if (isOff)
            {
                words.RemoveAt(i);
                if(word==activeWord)
                activeWord = null;
                hasActiveWord = false;
                score -= 3;
                lives--;
            }
        }
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore = score;
        }
        if (score < 0)
        {
            score = 0;
        }
        if(lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        scoreText.text ="Score : "  + score.ToString();
        highScoreText.text = "High Score : " + highScore.ToString();
        livesText.text = "Lives Left : " + lives.ToString();
    }
    public void TypeWord(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    hasActiveWord = true;
                    activeWord = word;
                    activeWord.TypeLetter();
                    break;
                }
            }
        }
        if(hasActiveWord && activeWord.WordTyped())
        {
            score += 10;
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
