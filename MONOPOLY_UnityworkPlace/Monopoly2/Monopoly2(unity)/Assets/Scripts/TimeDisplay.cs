using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText;

    void Update()
    {
        DateTime currentTime = DateTime.Now;
        timeText.text = "Current Time:\n " + currentTime.ToString("HH:mm:ss");
    }
}