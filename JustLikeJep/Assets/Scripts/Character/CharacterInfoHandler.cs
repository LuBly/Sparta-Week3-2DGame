using System;
using TMPro;
using UnityEngine;

public class CharacterInfoHandler : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI name;

    protected virtual void Awake()
    {
        SetCharacter();   
    }

    protected virtual void SetCharacter() { }

    // 매개 변수가 없다면 playerInfo에서 값을 가져오고
    protected virtual void SetName() { }

    // 매개 변수가 있다면 playerInfo에 값을 변경해준다.
    public virtual void SetName(string inputName) { }

    public virtual string GetName() 
    {
        return "";
    }
}
