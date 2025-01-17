using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public GameObject[] blocks; // The blocks that make up the circular path
    private int currentBlock = 0; // The current block that the Zombie is on

    private Animator Zombie_animator;
    private bool ZombieisMoving = false; // Whether the Zombie is moving
    private UIController uiController; // Reference to the UIController script
    public ZombieMoney ZombieisMove;
    private void Start()
    {
        Zombie_animator = GetComponent<Animator>();
        uiController = FindObjectOfType<UIController>(); // Find the UIController script in the scene
    }

    private void Update()
    {
        if (ZombieisMove.ZombiecanMove)
        {
            if (ZombieisMoving)
            {
                return; // If the Zombie is moving, don't process the Zombie's input
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                int diceNumber = Random.Range(1, 7); // Roll the dice
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
            ZombieisMoving = true;
            Zombie_animator.SetBool("ZombieisRunning", true);

            for (int i = 0; i < steps; i++)
            {
                Vector3 ZombietargetPosition = blocks[(currentBlock + 1) % blocks.Length].transform.position;

                while (Vector3.Distance(transform.position, ZombietargetPosition) > 0.01f)
                {
                    Vector3 moveDirection = (ZombietargetPosition - transform.position).normalized;
                    transform.position += moveDirection * Time.deltaTime;
                    transform.rotation = Quaternion.LookRotation(moveDirection);
                    yield return null;
                }

                currentBlock = (currentBlock + 1) % blocks.Length;
            }

            Zombie_animator.SetBool("ZombieisRunning", false);
            ZombieisMoving = false;
        }
    }
}


