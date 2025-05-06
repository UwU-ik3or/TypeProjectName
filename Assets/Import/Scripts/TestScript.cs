using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public HandCell cell;
    public Sprite TestImage;
    public bool Worked = false;

    private void FillCell(HandCell cell) {
        cell.cellOwner = "HandItem";
        cell.cellImage.sprite = TestImage;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (!Worked) {
                FillCell(cell);
                Worked = true;
            }
            else { print("Ячейка уже заполнена"); }
        }
        else if (Input.GetMouseButtonDown(1)) {
            if (!Worked) {
                cell.RemoveCellData(cell);
                Worked = false;
            }
            else { print("Ячейка уже пустая"); }
        }
    }
}
