using UnityEngine;

public class Item_Interact : MonoBehaviour, IInteractable, IInspectable
{
    public void Interact() { Debug.Log($"�� ���������������� �: {gameObject}"); }
    public void Inspect() { Debug.Log($"�� ������������ �������: {gameObject}"); }
}
