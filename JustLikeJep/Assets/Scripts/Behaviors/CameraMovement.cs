using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    Transform player; // 플레이어의 위치정보를 가져올 변수

    private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
