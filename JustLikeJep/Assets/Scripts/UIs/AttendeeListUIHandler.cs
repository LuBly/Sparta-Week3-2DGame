using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class AttendeeListUIHandler : MonoBehaviour
{
    [SerializeField] AttendeeManager attendeeManager;
    [SerializeField] Transform contentsTransform;
    [SerializeField] GameObject nameTextPrefab;


    private void OnEnable()
    {
        CreateNameList();
    }

    private void CreateNameList()
    {
        // NameList를 받아올 때마다 갱신
        attendeeManager.updateList();
        foreach(string name in attendeeManager.attendeeNameList)
        {
            GameObject newText = Instantiate(nameTextPrefab, contentsTransform);
            newText.GetComponent<TextMeshProUGUI>().text = name;
        }
    }

    private void OnDisable()
    {
        // 정보 갱신을 위해 Contant의 자식 객체 전부 삭제
        DestroyContents();
    }

    private void DestroyContents()
    {
        foreach(Transform child in contentsTransform)
        {
            Destroy(child.gameObject);
        }
    }
}
