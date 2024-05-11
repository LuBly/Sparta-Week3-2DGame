using System;
using TMPro;
using UnityEngine;

public class CharacterInfoHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private PlayerInfoSO playerInfo;
    private void Start()
    {
        SettingName();   
    }

    private void SettingName()
    {
        playerName.text = playerInfo.name;
    }
}