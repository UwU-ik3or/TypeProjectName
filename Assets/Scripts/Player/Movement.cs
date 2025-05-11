using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Movement : MonoBehaviour
{
    public float speed = 5f; // �������� ��������
    public float jumpHeight = 2f; // ������ ������
    private CharacterController controller;
    private Vector3 velocity;
    public bool isGrounded;
    public Camera playerCamera;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // �������� �� �����
        isGrounded = controller.isGrounded;

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0; // ���������� ������������ �������� ��� �����������
        }

        // �������� ���� �� ������
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 cameraForward = playerCamera.transform.forward;
        Vector3 cameraRight = playerCamera.transform.right;

        cameraForward.y = 0;
        cameraRight.y = 0;

        cameraForward.Normalize();
        cameraRight.Normalize();

        // �������� ���������
        Vector3 direction = (cameraRight * moveX + cameraForward * moveZ).normalized;
        Vector3 move = direction;


        controller.Move(move * speed * Time.deltaTime);

        // ������
        if (Input.GetKeyDown(KeyCode.F) && isGrounded)
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y);
        }

        // ��������� ����������
        velocity.y += Physics.gravity.y * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
