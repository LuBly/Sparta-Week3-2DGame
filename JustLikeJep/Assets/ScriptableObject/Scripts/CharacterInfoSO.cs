using UnityEngine;
[CreateAssetMenu(fileName = "DefaultCharacterInfo", menuName = "Info/Character/Default", order = 0)]
public class CharacterInfoSO : ScriptableObject
{
    [Header("정적 스텟")]
    public string name;
}
