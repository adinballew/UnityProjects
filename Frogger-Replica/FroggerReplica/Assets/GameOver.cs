using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Text highScoreText;
    List<int> highScoreInt = new List<int>();
    void Start()
    {
        List<string> highScore = File.ReadAllLines("Assets/highscores.txt").ToList();
        foreach (string line in highScore)
        {
            int x = 0;
            int.TryParse(line, out x);
            if (Score.CurrentScore >= x)
            {
                highScoreInt.Add(Score.CurrentScore);
                Score.CurrentScore = 0;
            }
            highScoreInt.Add(x);
        }
        highScoreInt.Reverse();

        for (int i = 0; i < 5; i++)
        {
            highScoreText.text += "\n" + highScoreInt[i].ToString();
        }
    }

}
