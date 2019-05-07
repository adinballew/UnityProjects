using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text speed;
    public Text size;
    public Text remainTimeText;

    float timer;
    float remainingTime;

    // Start is called before the first frame update
    void Start()
    {
        speed.text = Intro.speed.ToString();
        size.text = Intro.size.ToString();

        timer = 120f;
        remainingTime = timer - Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime = timer - Time.time;
        string minutes = ((int)remainingTime / 60).ToString();
        string seconds = (remainingTime % 60).ToString("0");

            if (remainingTime > 0)
                remainTimeText.text = minutes + ":" + seconds;
            if (remainingTime <= 0)
            {
                Debug.Log("Game Over");
                UnityEngine.SceneManagement.SceneManager.LoadScene(2);
            }
    }
}
