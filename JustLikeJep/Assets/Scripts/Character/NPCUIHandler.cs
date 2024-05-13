using System;
using UnityEngine;

public class NPCUIHandler : MonoBehaviour
{
    //GameObject PopUpUI;
    [SerializeField] private LayerMask targetLayer;
    [SerializeField] private GameObject PopUpUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 충돌한 오브젝트가 Playe라면 팝업UI 오픈
        if (IsLayerMatced(targetLayer.value, collision.gameObject.layer))
        {
            OpenNPCUI();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (IsLayerMatced(targetLayer.value, collision.gameObject.layer))
        {
            CloseNPCUI();
        }
    }

    private bool IsLayerMatced(int layerMask, int objectLayer)
    {
        return layerMask == (layerMask | (1 << objectLayer));
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
