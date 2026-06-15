using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;

    public Vector3 offset = new Vector3(0, 3, -5);

    void LateUpdate()
    {
        transform.position = player.position + offset;
        transform.LookAt(player);
    }
}