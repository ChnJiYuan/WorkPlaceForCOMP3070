using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Regame : MonoBehaviour
{
    public Button regame;
    void Start()
    {
        // 绑定按钮点击事件
        regame.onClick.AddListener(OnButtonPress);
        
    }
    public void OnButtonPress()
    {
     SceneManager.LoadScene(0);
        
    }
    }
