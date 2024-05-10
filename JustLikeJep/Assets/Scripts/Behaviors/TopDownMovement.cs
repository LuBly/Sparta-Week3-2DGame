using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    TopDownController movementController;
    Rigidbody2D movementRigidbody;

    Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        movementController.OnMoveEvent += Move;
    }
    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        // Todo : 플레이어의 이동속도 생성 및 적용 5f -> Stat.Speed
        direction = direction * 5f;
        movementRigidbody.velocity = direction;
    }

    
}