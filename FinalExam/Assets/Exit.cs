using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Text score;
    public Text allScore;

    System.IO.StreamWriter writer = new System.IO.StreamWriter("Assets/scores.txt", true);

    // Start is called before the first frame update
    void Start()
    {
        writer.WriteLine(HighScores.Name);
        writer.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
