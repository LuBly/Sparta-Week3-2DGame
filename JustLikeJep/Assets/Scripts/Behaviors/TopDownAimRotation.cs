using System;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] Transform headPivot;
    TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        // OnLook
        RotateHead(newAimDirection);
    }

    private void RotateHead(Vector2 direction)
    {
        // ���콺 ��ġ ���� ���
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Debug.Log(rotZ);
        // ������ ���� ȸ��
        bool isAimRight = Mathf.Abs(rotZ) <= 90f;
        Flip(isAimRight);

        // ToDo : �Ӹ�ȸ�� �ݰ� �߰�
        headPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    private void Flip(bool isAimRight)
    {
        // bone���� �����Ǿ� Flip ��� �Ұ� => scale�� ���� ȸ���� ����
        Vector3 flipPlayerScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        Vector3 flipBoneScale = new Vector3(headPivot.localScale.x, headPivot.localScale.y, headPivot.localScale.z);
        if(isAimRight)
        {
            flipPlayerScale.x = 1;
            flipBoneScale.x = 1;
            flipBoneScale.y = 1;
        }
        else
        {
            flipPlayerScale.x = -1;
            flipBoneScale.x = -1;
            flipBoneScale.y = -1;
        }
        transform.localScale = flipPlayerScale;
        headPivot.localScale = flipBoneScale;
    }
}
