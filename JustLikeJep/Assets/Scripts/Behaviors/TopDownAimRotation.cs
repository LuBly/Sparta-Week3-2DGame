using System;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] Transform headPivot;
    [SerializeField] Transform playerRenderer;
    TopDownController controller;

    // 최초 상태의 origScale을 저장해둘 변수
    Vector3 origPlayerScale;

    private void Awake()
    {
        controller = GetComponentInParent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
        origPlayerScale = playerRenderer.localScale;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        // OnLook
        RotateHead(newAimDirection);
    }

    private void RotateHead(Vector2 direction)
    {
        // 마우스 위치 각도 계산
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // 각도에 따른 회전
        bool isAimRight = Mathf.Abs(rotZ) <= 90f;
        Flip(isAimRight);

        // ToDo : 머리회전 반경 추가
        headPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    private void Flip(bool isAimRight)
    {
        // bone으로 구성되어 Flip 사용 불가 => scale을 통해 회전을 구현
        Vector3 flipPlayerScale = new Vector3(playerRenderer.localScale.x, playerRenderer.localScale.y, playerRenderer.localScale.z);
        Vector3 flipBoneScale = new Vector3(headPivot.localScale.x, headPivot.localScale.y, headPivot.localScale.z);
        if(isAimRight)
        {
            flipPlayerScale.x = origPlayerScale.x;
            flipBoneScale.x = 1;
            flipBoneScale.y = 1;
        }
        else
        {
            flipPlayerScale.x = -origPlayerScale.x;
            flipBoneScale.x = -1;
            flipBoneScale.y = -1;
        }

        playerRenderer.localScale = flipPlayerScale;
        headPivot.localScale = flipBoneScale;
    }
}
