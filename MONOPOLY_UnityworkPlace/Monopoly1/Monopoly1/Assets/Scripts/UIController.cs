using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject diceNumberPanel;
    public Text diceNumberText;
    public GameObject buyMenu; // The buy menu panel

    private bool isUIVisible = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isUIVisible)
            {
                HideDiceNumber();
                // 继续玩家控制的角色移动的逻辑
            }
        }
    }

    public void ShowDiceNumber(int diceNumber)
    {
        diceNumberText.text = "Dice Number: " + diceNumber;
        diceNumberPanel.SetActive(true);
        isUIVisible = true;
    }

    public void HideDiceNumber()
    {
        diceNumberPanel.SetActive(false);
        isUIVisible = false;
    }

    public void ToggleBuyMenu()
    {
        bool isActive = buyMenu.activeSelf;
        buyMenu.SetActive(!isActive); // Toggle the active state of the buy menu
    }
}
