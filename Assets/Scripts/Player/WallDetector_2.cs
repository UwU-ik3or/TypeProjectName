using UnityEngine;

public class WallDetector2 : MonoBehaviour
{
    public PlayerMovementN playerMov;
    public float rayDistance = 0.5f;

    private void Awake() {
        playerMov = GetComponent<PlayerMovementN>();
    }

    private void Update() {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayDistance)) {
            if (hit.collider.CompareTag("Wall")) {
                //playerMov.WallHitEnable();
                Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.red);
            }
        }
        else {
            playerMov.WallHitDisable();
            Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.green);
        }
    }
}
