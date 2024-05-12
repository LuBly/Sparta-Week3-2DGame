using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttendeeManager : MonoBehaviour
{
    [SerializeField] public List<string> attendeeNameList = new List<string>();
    void Awake()
    {
        updateList();
    }

    void updateList()
    {
        foreach(Transform child in transform) 
        {
            attendeeNameList.Add(child.GetComponent<CharacterInfoHandler>().GetName());
        }
    }
}
