using System;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    //Controller���� �� ��ü�鿡�� ȣ���� �� �ִ� event���� ��Ƶδ� ��ü
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
