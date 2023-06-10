using UnityEngine;

public class DiceController : MonoBehaviour
{
    public float throwForce = 1f; // The force to apply when throwing the dice
    public UIController uiController; // The UI controller
    public int diceNumber;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowDice();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            uiController.HideDiceNumber();
            // Start moving the character here
        }
    }

    void ThrowDice()
    {
        // Reset the dice's position and rotation
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;

        // Apply a random force to the dice
        Vector3 force = new Vector3(
            x: Random.Range(-throwForce, throwForce),
            y: Random.Range(0, throwForce),
            z: Random.Range(-throwForce, throwForce)
        );
        _rigidbody.AddForce(force);

        // Generate a dice number and show it
        diceNumber = Random.Range(1, 7);
        uiController.ShowDiceNumber(diceNumber);
    }
}