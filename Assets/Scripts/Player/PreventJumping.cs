using UnityEngine;

public class PreventJumping : MonoBehaviour
{
    /*
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    [System.Obsolete]
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Остановка движения по оси Y
            Vector3 normal = collision.contacts[0].normal;
            if (Mathf.Abs(normal.y) > 0.5f)
            {
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);
            }
        }
    }
    */
}
