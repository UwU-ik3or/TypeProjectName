using UnityEngine;

public class NPC_Interact : MonoBehaviour, IInteractable
{
    public void Interact() { Debug.Log("Вы общаетесь с НПС. Вы получили много интересной информации"); }
    public void Inspect() { Debug.Log($"Вы осматриваете персонажа. На вид он не плохой"); }
}
