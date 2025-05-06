using UnityEngine;
using UnityEngine.UI;

public class HandCell : MonoBehaviour
{
    public GameObject cell;
    public Image cellImage;
    public string cellOwner;

    public void RemoveCellData(HandCell cell) {
        this.cellImage = null;
        this.cellOwner = "";
    }
}

