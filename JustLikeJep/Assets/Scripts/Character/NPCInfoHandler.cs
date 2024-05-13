using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class NPCInfoHandler : CharacterInfoHandler
{
    [SerializeField] private NPCInfoSO NPCInfo;
    [SerializeField] private TextMeshProUGUI? NPCNameTag;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void SetCharacter()
    {
        SetName();
        if(NPCNameTag != null)
        {
            SetNameTag();
        }
    }

    // 매개 변수가 없다면 playerInfo에서 값을 가져오고
    protected override void SetName()
    {
        name.text = NPCInfo.name;
    }

    private void SetNameTag()
    {
        NPCNameTag.text = NPCInfo.name;
    }

    public override string GetName()
    {
        return NPCInfo.name;
    }

    public GameObject GetNPCUI()
    {
        // popupUI가 없다면 종료
        if (NPCInfo.PopUpUI == null) return null; ;

        return NPCInfo.PopUpUI; 
    }
}
