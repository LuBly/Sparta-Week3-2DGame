using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class AttendeeListUIHandler : MonoBehaviour
{
    [SerializeField] AttendeeManager attendeeManager;
    [SerializeField] Transform contentsTransform;
    [SerializeField] TMP_FontAsset font;
    Color fontColor = Color.black;


    private void OnEnable()
    {
        CreateNameList();
    }

    // TODO
    // text 오브젝트 생성하기
    private void CreateNameList()
    {
        foreach(string name in attendeeManager.attendeeNameList)
        {
            TextMeshProUGUI newText = new TextMeshProUGUI();
            newText.text = name;
            newText.font = font;
            newText.color = fontColor;
            Instantiate(newText);
        }
    }
}
