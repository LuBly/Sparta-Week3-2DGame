using UnityEngine;

public class PlayerInfoHandler : CharacterInfoHandler
{
    [SerializeField] private PlayerInfoSO playerInfo;
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void SetCharacter()
    {
        SetName();
        SetPlayerRenderer();
    }

    // 매개 변수가 없다면 playerInfo에서 값을 가져오고
    protected override void SetName()
    {
        name.text = playerInfo.name;
    }

    // 매개 변수가 있다면 playerInfo에 값을 변경해준다.
    public override void SetName(string inputName)
    {
        name.text = inputName;
        playerInfo.name = inputName;
    }

    public override string GetName()
    {
        return playerInfo.name;
    }

    private void SetPlayerRenderer()
    {
        Instantiate(playerInfo.PlayerRenderer, transform);
    }
}