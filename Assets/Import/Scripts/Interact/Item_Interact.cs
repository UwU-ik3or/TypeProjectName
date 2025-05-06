using UnityEngine;

public class Item_Interact : MonoBehaviour, IInteractable, IInspectable
{
    public void Interact() { Debug.Log($"Вы взаимодействуете с: {gameObject}"); }
    public void Inspect() { Debug.Log($"Вы осматриваете предмет: {gameObject}"); }
}
