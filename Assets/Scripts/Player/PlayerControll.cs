using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float Impulse = 20f;
    public float speed = 10f;
    private Rigidbody rBody;
    //public Camera playerCamera;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        ChangeSpeed();

        float horizontal = Input.GetAxis("Horizontal"); // Получаем ввод по оси X
        float vertical = Input.GetAxis("Vertical"); // Получаем ввод по оси Z

        /*
        Vector3 cameraForward = playerCamera.transform.forward;
        Vector3 cameraRight = playerCamera.transform.right;

        cameraForward.y = 0;
        cameraRight.y = 0;

        cameraForward.Normalize();
        cameraRight.Normalize();

        Vector3 direction = (cameraRight * horizontal + cameraForward * vertical);
        Vector3 velocity = direction * speed;
        */

        rBody.MovePosition(rBody.position * Time.fixedDeltaTime); // Перемещаем игрока
    }

    private void ChangeSpeed()
    {
        if (Input.GetKey(KeyCode.LeftShift)) { speed = 8f; }
        else { speed = 5f; }
    }
}