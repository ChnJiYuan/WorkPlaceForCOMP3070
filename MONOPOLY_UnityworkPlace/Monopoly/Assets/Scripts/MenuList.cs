using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuList : MonoBehaviour
{
    public GameObject menuList; //购买列表

    [SerializeField] private bool menuKeys = true; //引入购买列表
    [SerializeField] private AudioSource bgmSound; //引入背景音乐


    // 
    void Update()
    {
        if (menuKeys)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                menuList.SetActive(true);
                menuKeys = false;
                Time.timeScale = 0; //时间暂停
                bgmSound.Pause(); //音乐暂停
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuList.SetActive(false);
            menuKeys = true;
            Time.timeScale = 1; //时间开始
            bgmSound.Play(); //音乐播放
        }

    }

    public void Restart() //重新开始
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Exit() //退出游戏
    {
        Application.Quit();

    }

}
