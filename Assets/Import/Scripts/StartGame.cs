using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject Rifle;

    private void Start() {
        Rifle.SetActive(false);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.G)) {
            StartMassacre();
        }
    }

    private void StartMassacre() {
        Rifle.SetActive(true);
    }
}
