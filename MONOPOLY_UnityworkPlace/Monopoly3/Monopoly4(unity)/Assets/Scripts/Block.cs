using UnityEngine;

public class Block : MonoBehaviour
{
    public bool isBought = false;
    public GameObject subCube; // 将你的subCube拖到这个公有变量上

    public void MarkAsBought()
    {
        isBought = true;
        // 改变subCube的颜色
        subCube.GetComponent<Renderer>().material.color = Color.red;
    }
}
