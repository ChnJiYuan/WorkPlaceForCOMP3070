using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject uiCanvas;

    private void Start()
    {
        // 游戏启动时的初始化逻辑
        // 可以在这里进行游戏数据的初始化、场景设置等
    }

    

    public void ShowUI()
    {
        // 显示UI界面的逻辑
        uiCanvas.SetActive(true);
    }

    public void HideUI()
    {
        // 隐藏UI界面的逻辑
        uiCanvas.SetActive(false);
    }

}
