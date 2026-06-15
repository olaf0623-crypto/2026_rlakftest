using UnityEngine;

public class JumpBlock : MonoBehaviour
{
    public float jumpPower = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            rb.linearVelocity = Vector3.zero;
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}