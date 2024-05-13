using System;
using UnityEngine;

public class NPCHandler : MonoBehaviour
{
    GameObject PopUpUI;
    [SerializeField] private LayerMask targetLayer;

    private void Awake()
    {
        PopUpUI = GetComponent<NPCInfoHandler>().GetNPCUI();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 충돌한 오브젝트가 Playe라면 팝업UI 오픈
        if(collision.gameObject.layer == targetLayer)
        {
            OpenNPCUI();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == targetLayer)
        {
            CloseNPCUI();
        }
    }

    private void OpenNPCUI()
    {
        PopUpUI.SetActive(true);
    }

    private void CloseNPCUI()
    {
        PopUpUI.SetActive(false);
    }

}
