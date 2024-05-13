using System;
using UnityEngine;

public class NPCUIHandler : MonoBehaviour
{
    //GameObject PopUpUI;
    [SerializeField] private LayerMask targetLayer;
    [SerializeField] private GameObject PopUpUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.layer);
        Debug.Log((int)targetLayer);
        // 충돌한 오브젝트가 Playe라면 팝업UI 오픈
        if (collision.gameObject.layer == (int)targetLayer)
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
