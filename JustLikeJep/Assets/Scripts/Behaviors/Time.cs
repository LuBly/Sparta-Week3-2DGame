using System;
using TMPro;
using UnityEngine;

public class Time : MonoBehaviour
{
    TextMeshProUGUI textTMP;

    private void Awake()
    {
        textTMP = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        DateTime time = DateTime.Now;
        SetTimeText(time);
    }

    private void SetTimeText(DateTime time)
    {
        textTMP.text = time.ToString("HH : mm");
    }
}
