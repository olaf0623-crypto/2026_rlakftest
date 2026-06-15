using UnityEngine;

public class PlayerFallCheck : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -10)
        {
            GameManager.Instance.GameOver();
        }
    }
}