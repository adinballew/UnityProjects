using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public Slider slider;
    public Toggle toggle;
    public Dropdown dropdown;

    public static float speed;
    public static int size;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
        slider.value = 0f;
        toggle.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle.isOn)
        {
            slider.enabled = false;
        }
        if (!toggle.isOn)
        {
            slider.enabled = true;
        }
    }

    public void UpdateSlider(float val)
    {
        slider.value = val;
        Debug.Log(slider.value);
        speed = slider.value;
    }

    public void UpdateToggle(bool val)
    {
        if (val == true)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }
        Debug.Log(toggle.isOn);
    }

    public void UpdateDropdown(int val)
    {
        switch (val)
        {
            case 0:
                size = 1;
                break;
            case 1:
                size = 2;
                break;
            case 2:
                size = 3;
                break;
            default:
                size = 1;
                break;
        }
        Debug.Log(size);
    }
}
