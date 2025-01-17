using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseBuyList : MonoBehaviour
{
    public GameObject Buylist; // 弹窗UI游戏对象

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        // 关闭弹窗
        Buylist.SetActive(false);
    }
}