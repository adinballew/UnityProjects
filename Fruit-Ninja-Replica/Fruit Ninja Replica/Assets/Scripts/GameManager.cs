using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public Text modeText;

    // Start is called before the first frame update
    void Start()
    {
        Mode();
    }

    private void Mode()
    {
        switch(Options.mode)
        {
            case 0:
                modeText.text += "Limitless";
                break;
            case 1:
                modeText.text += "Speedrun (1 min)";
                break;
            case 2:
                modeText.text += "Speedrun (2 min)";
                break;
            default:
                modeText.text += "Limitless";
                break;
        }
    }
}