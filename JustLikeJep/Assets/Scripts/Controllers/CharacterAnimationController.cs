using System;
using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    // 애니메이션에 필요한 값들의 해쉬값 미리 생성
    // string 값 비교의 리소스가 크기 때문에 O(1)의 해쉬 값을 미리 생성해둔다.
    private static readonly int isMove = Animator.StringToHash("isMove");
    
    // 값 전환에 대한 임계치, 너무 조금 움직였을 땐 애니매이션 변화X 위해 사용
    private readonly float magnituteThreshhold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 dir)
    {
        // Destroy 예외 처리
        if (animator == null) return;
        animator.SetBool(isMove, dir.magnitude > magnituteThreshhold);
    }
}