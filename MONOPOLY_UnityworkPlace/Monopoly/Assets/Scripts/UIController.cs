using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text diceNumberText; // The text object that displays the dice number
    public CanvasGroup diceNumberCanvasGroup; // The Canvas Group component on the text object

    public void ShowDiceNumber(int number)
    {
        diceNumberText.text = "Dice Number: " + number;
        diceNumberCanvasGroup.alpha = 1; // Show the text object
    }

    public void HideDiceNumber()
    {
        diceNumberCanvasGroup.alpha = 0; // Hide the text object
    }
}