using UnityEngine;

public class PlayerMovementN : MonoBehaviour
{
    [SerializeField]
    private float speedReductionFactor = 0.5f;


    private float Impulse = 20f;

    [SerializeField]
    private float normalSpeed = 5f;
    private float R_normalSpeed;
    [SerializeField]
    private float sprintSpeed = 8f;
    private float R_sprintSpeed;
    private Rigidbody rBody;
    public Camera playerCamera;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        R_normalSpeed = normalSpeed * speedReductionFactor;
        R_sprintSpeed = sprintSpeed * speedReductionFactor;
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 cameraForward = playerCamera.transform.forward;
        Vector3 cameraRight = playerCamera.transform.right;

        cameraForward.y = 0;
        cameraRight.y = 0;

        cameraForward.Normalize();
        cameraRight.Normalize();

        Vector3 direction = (cameraRight * horizontal + cameraForward * vertical).normalized;
        float speed = ChangeSpeed();

        Vector3 velocity = direction * speed;

        rBody.MovePosition(rBody.position + velocity * Time.fixedDeltaTime);
    }

    private float ChangeSpeed() {
        return Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : normalSpeed;
    }

    public void WallHit() {
        normalSpeed = 0;
        sprintSpeed = 0;
    }

    public void WallHitDisable() {
        normalSpeed = 5f;
        sprintSpeed = 8f;
    }
}
