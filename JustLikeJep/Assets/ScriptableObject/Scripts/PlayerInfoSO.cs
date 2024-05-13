using UnityEngine;
[CreateAssetMenu(fileName = "PlayerInfo", menuName = "Info/Character/Player", order = 1)]
public class PlayerInfoSO : CharacterInfoSO
{
    // 플레이 중 절대 안바뀌는 정적 데이터들만 저장
    public GameObject? PlayerRenderer;
}
