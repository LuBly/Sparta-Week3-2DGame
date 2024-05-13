using UnityEngine;

public class NPCPopUpUIButton : MonoBehaviour
{
    [SerializeField] private GameObject m_NPCResponseUI;

    public void CallNPC()
    {
        gameObject.SetActive(false);
        m_NPCResponseUI.SetActive(true);
    }
}
