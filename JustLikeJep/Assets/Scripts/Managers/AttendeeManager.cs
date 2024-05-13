using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttendeeManager : MonoBehaviour
{
    [SerializeField] public List<string> attendeeNameList = new List<string>();

    public void updateList()
    {
        List<string> curNameList = new List<string>();
        foreach(Transform child in transform) 
        {
            curNameList.Add(child.GetComponent<CharacterInfoHandler>().GetName());
        }
        attendeeNameList = curNameList;
    }
}
