using UnityEngine;

public class PlayerInteract : MonoBehaviour, IInteractable
{
    public void Interact() { Debug.Log("����� ��������������� � �����"); }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit)) {
            IInteractable interact = hit.collider.GetComponent<IInteractable>();
            IInspectable inspect = hit.collider.GetComponent<IInspectable>();
            if (interact != null) {
                Debug.Log("� �������� ����� �����������������");
                if (Input.GetKeyDown(KeyCode.F)) { interact.Interact(); }
            }
            /*
            else if (inspect != null) {
                Debug.Log("������ ����� ���������.");
                if (Input.GetKeyDown(KeyCode.E)) { inspect.Inspect(); }
            }
            */
        }
    }
}
