using System;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    //Controller들은 각 객체들에서 호출할 수 있는 event들을 모아두는 객체
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
