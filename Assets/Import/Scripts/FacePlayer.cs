using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 5f;

    void Update()
    {
        Vector3 directionTo = player.position - transform.position;
        directionTo.y = 0;

        Quaternion targetRotation = Quaternion.LookRotation(directionTo);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
