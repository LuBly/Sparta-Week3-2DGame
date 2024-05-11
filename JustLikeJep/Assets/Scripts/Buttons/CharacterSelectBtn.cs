using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectBtn : MonoBehaviour
{
    [SerializeField] Image? characterBtnImage;

    // 플레이어 프리팹을 보관
    [SerializeField] List<GameObject> players = new List<GameObject>();
    [SerializeField] List<Sprite> playerImages = new List<Sprite>();
    
    public void SelectPlayer(int idx)
    {
        DataManager.Instance.playerInfo.PlayerRenderer = players[idx];
        characterBtnImage.sprite = playerImages[idx];
        gameObject.SetActive(false);
    }
}
