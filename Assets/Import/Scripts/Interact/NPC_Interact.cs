using UnityEngine;

public class NPC_Interact : MonoBehaviour, IInteractable
{
    public void Interact() { Debug.Log("�� ��������� � ���. �� �������� ����� ���������� ����������"); }
    public void Inspect() { Debug.Log($"�� ������������ ���������. �� ��� �� �� ������"); }
}
