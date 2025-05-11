using UnityEngine;

public class WallDetector : MonoBehaviour
{
    public float rayDistance = 0.5f; // ��������� Raycast
    public PlayerMovementN playerMov; // ������ �� ������ PlayerMovementN

    private void Awake()
    {
        playerMov = GetComponent<PlayerMovementN>();
    }

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (hit.collider.CompareTag("Wall"))
            {
            }
        }
        else
        {
        }
    }
}
