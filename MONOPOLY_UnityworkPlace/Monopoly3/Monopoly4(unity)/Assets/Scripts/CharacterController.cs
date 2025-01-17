using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject[] blocks; // The blocks that make up the circular path
    private int currentBlock = 0; // The current block that the character is on

    private Animator _animator;
    private bool isMoving = false; // Whether the character is moving
    private UIController uiController; // Reference to the UIController script
    public PlayerMoney isMove;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        uiController = FindObjectOfType<UIController>(); // Find the UIController script in the scene
    }

    private void Update()
    {
        if (isMove.canMove)
        {
            if (isMoving)
            {
                return; // If the character is moving, don't process the player's input
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                int diceNumber = Random.Range(1, 7); // Roll the dice
                uiController.ShowDiceNumber(diceNumber); // Show UI with dice number
                StartCoroutine(MoveToNextBlock(diceNumber)); // Move according to the dice number
                
            }
            
            else
            {
                ResetDicePosition();
            }
            
        }

    void ResetDicePosition()
    {
        // 获取骰子的DiceController脚本
        DiceController diceController = FindObjectOfType<DiceController>();

        // 调用骰子控制器的方法重置骰子位置
        diceController.ResetDicePosition();
    }







        IEnumerator MoveToNextBlock(int steps)
        {
            isMoving = true;
            _animator.SetBool("isRunning", true);

            for (int i = 0; i < steps; i++)
            {
                Vector3 targetPosition = blocks[(currentBlock + 1) % blocks.Length].transform.position;

                while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
                {
                    Vector3 moveDirection = (targetPosition - transform.position).normalized;
                    transform.position += moveDirection * Time.deltaTime;
                    transform.rotation = Quaternion.LookRotation(moveDirection);
                    yield return null;
                }

                currentBlock = (currentBlock + 1) % blocks.Length;
            }

            _animator.SetBool("isRunning", false);
            isMoving = false;
        }
    }
}
