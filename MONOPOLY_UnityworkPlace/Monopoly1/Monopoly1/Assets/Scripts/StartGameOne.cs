using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameOne : MonoBehaviour
{
    private Button button;
    void Start()
    {
        // 绑定按钮点击事件
        button.onClick.AddListener(OnButtonPress);
    }
    public void OnButtonPress()
    {



        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}