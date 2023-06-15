using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour

{
    public GameObject StartCanvas;
    public Button Startbutton;
    public PlayerMoney StartAfterClick;
      void Start()
    {
        // 绑定按钮点击事件
        StartAfterClick.canMove=false;
        Startbutton.onClick.AddListener(OnButtonPress);
    }
    public void OnButtonPress()
    {
         StartCanvas.gameObject.SetActive(false);
         StartAfterClick.canMove=true;
    }


}