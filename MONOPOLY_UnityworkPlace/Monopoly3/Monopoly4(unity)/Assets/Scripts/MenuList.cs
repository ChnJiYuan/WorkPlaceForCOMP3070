using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuList : MonoBehaviour
{
    public GameObject menuList; //�����б�

    [SerializeField] private bool menuKeys = true; //���빺���б�
    [SerializeField] private AudioSource bgmSound; //���뱳������


    // 
    void Update()
    {
        if (menuKeys)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                menuList.SetActive(true);
                menuKeys = false;
                Time.timeScale = 0; //ʱ����ͣ
                bgmSound.Pause(); //������ͣ
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuList.SetActive(false);
            menuKeys = true;
            Time.timeScale = 1; //ʱ�俪ʼ
            bgmSound.Play(); //���ֲ���
        }

    }

    public void Restart() //���¿�ʼ
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Exit() //�˳���Ϸ
    {
        Application.Quit();

    }

}
