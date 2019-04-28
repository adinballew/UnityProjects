using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    [SerializeField]
    public Text fruitSizeText, spawnSpeedText, fruitSpeedText;

    public Scrollbar fruitSize, spawnSpeed, fruitSpeed;
    public static float fruitSizeVal, spawnSpeedVal, fruitSpeedVal;

    public Dropdown timeLimit;
    public static int mode;

    public Dropdown bladeSize;
    public static float blade;

    // Start is called before the first frame update
    void Start()
    {
        fruitSize.value = .5f;
        fruitSizeText.text = (100 * fruitSize.value).ToString("f0");
        spawnSpeed.value = .5f;
        spawnSpeedText.text = (100 * spawnSpeed.value).ToString("f0");
        fruitSpeed.value = .5f;
        fruitSpeedText.text = (100 * fruitSpeed.value).ToString("f0");
    }

    public void UpdateFruitSize(float val)
    {
        fruitSize.value = val;
        fruitSizeText.text = (100 * fruitSize.value).ToString("f0");
        fruitSizeVal = fruitSize.value;
        Debug.Log(val);
    }

    public void UpdateSpawnSpeed(float val)
    {
        spawnSpeed.value = val;
        spawnSpeedText.text = (100 * spawnSpeed.value).ToString("f0");
        spawnSpeedVal = spawnSpeed.value;
        Debug.Log(val);
    }

    public void UpdateFruitSpeed(float val)
    {
        fruitSpeed.value = val;
        fruitSpeedText.text = (100 * fruitSpeed.value).ToString("f0");
        fruitSpeedVal = fruitSpeed.value;
        Debug.Log(val);
    }

    public void UpdateTimeLimit()
    {
        mode = timeLimit.value;
    }

    public void UpdateBladeSize()
    {
        switch(bladeSize.value)
        {
            case 0:
                blade = .1f;
                break;
            case 1:
                blade = 1;
                break;
            case 2:
                blade = 2;
                break;
            default:
                blade = 1;
                break;
        }
    }
}