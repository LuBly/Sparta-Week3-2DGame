using System;
using TMPro;
using UnityEngine;

public class CharacterInfoHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private PlayerInfoSO playerInfo;
    private void Awake()
    {
        SetPlayer();   
    }

    private void SetPlayer()
    {
        SetName();
        SetPlayerRenderer();
    }

    private void SetName()
    {
        playerName.text = playerInfo.name;
    }

    private void SetPlayerRenderer()
    {
        Instantiate(playerInfo.PlayerRenderer, transform);
    }
}