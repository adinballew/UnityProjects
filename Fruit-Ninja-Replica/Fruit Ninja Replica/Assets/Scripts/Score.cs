using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text fruitsSpawnedText;
    public Text fruitsLostText;

    public static int fruitsSpawned;
    public static int fruitsLost;

    void Start()
    {
        fruitsSpawned = 0;
        fruitsLost = 0;
        fruitsSpawnedText.text = "Spawned: " + fruitsSpawned.ToString();
        fruitsLostText.text = "Lost: " + fruitsLost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        fruitsSpawnedText.text = "Spawned: " + fruitsSpawned.ToString();
        fruitsLostText.text = "Lost: " + fruitsLost.ToString();
    }
}
