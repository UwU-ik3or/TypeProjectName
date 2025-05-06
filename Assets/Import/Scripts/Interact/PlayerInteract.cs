using UnityEngine;

public class PlayerInteract : MonoBehaviour, IInteractable
{
    public void Interact() { Debug.Log("Игрок взаимодействует с миром"); }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit)) {
            IInteractable interact = hit.collider.GetComponent<IInteractable>();
            IInspectable inspect = hit.collider.GetComponent<IInspectable>();
            if (interact != null) {
                Debug.Log("С объектом можно взаимодействовать");
                if (Input.GetKeyDown(KeyCode.F)) { interact.Interact(); }
            }
            /*
            else if (inspect != null) {
                Debug.Log("Объект можно осмотреть.");
                if (Input.GetKeyDown(KeyCode.E)) { inspect.Inspect(); }
            }
            */
        }
    }
}
