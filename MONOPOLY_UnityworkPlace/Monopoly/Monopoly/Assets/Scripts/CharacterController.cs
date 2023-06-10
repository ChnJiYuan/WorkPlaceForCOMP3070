using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject[] blocks; // The blocks that make up the circular path
    private int currentBlock = 0; // The current block that the character is on

    private Animator _animator;
    private bool isMoving = false; // Whether the character is moving

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            return; // If the character is moving, don't process the player's input
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int diceNumber = Random.Range(1, 7); // Roll the dice
            StartCoroutine(MoveToNextBlock(diceNumber)); // Move according to the dice number
        }
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