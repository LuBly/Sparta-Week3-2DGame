using UnityEngine;

public class NPCPopUpUIButton : MonoBehaviour
{
    [SerializeField] private GameObject m_CallNPCButton;
    [SerializeField] private GameObject m_NPCResponseUI;

    public void CallNPC()
    {
        m_CallNPCButton.SetActive(false);
        m_NPCResponseUI.SetActive(true);
    }
}
