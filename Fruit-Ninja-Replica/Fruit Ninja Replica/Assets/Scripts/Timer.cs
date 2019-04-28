using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text remainTimeText;
    public float timer;
    public bool limitless;
    public float remainingTime;

    // Start is called before the first frame update
    void Start()
    {
        switch(Options.mode)
        {
            case 0:
                timer = 0;
                limitless = true;
                remainTimeText.text = "Limitless";
                break;
            case 1:
                timer = 60f;
                limitless = false;
                break;
            case 2:
                timer = 120f;
                limitless = false;
                break;
            default:
                timer = 0;
                limitless = true;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime = timer - Time.time;
        string minutes = ((int)remainingTime / 60).ToString();
        string seconds = (remainingTime % 60).ToString("0");

        if (!limitless)
        {
            if(remainingTime > 0)
                remainTimeText.text = minutes + ":" + seconds;
            if (remainingTime <= 0)
            {
                Debug.Log("Game Over");
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        }
    }
}
