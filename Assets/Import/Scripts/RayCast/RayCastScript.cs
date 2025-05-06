using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    public void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            Debug.Log("Попал в объект: " + objectHit.name);
        }
    }
}
