using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class HighScores : MonoBehaviour
{
    private static List<string> scoreList = System.IO.File.ReadAllLines("Assets/scores.txt", System.Text.Encoding.UTF8).ToList<string>();

    [SerializeField]
    public Text HighscoresText, PlayName;

    public static string Name;

    // Start is called before the first frame update
    void Start()
    {
        GetHighScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetHighScores()
    {
        HighscoresText.text = "";
        foreach(string score in scoreList)
        {
            HighscoresText.text += score + "\n";
        }
    }
}
