using UnityEngine;

public class DiceController : MonoBehaviour
{
    public GameObject emptyCube; // 透明立方体对象
    private Rigidbody _rigidbody;
    private Vector3 initialPosition; // 初始位置
    private bool isThrown = false;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false; // 禁用重力，使骰子不受重力影响
        initialPosition = transform.position; // 记录初始位置
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K))
        {
            if (isThrown)
            {
                ResetDicePosition();
            }
            else
            {
                ThrowDice();
            }
        }
    }

    public void ResetDicePosition()
    {
        _rigidbody.velocity = Vector3.zero; // 重置骰子速度
        transform.position = initialPosition; // 将骰子位置重置为初始位置

        isThrown = false;
    }




    private void ThrowDice()
    {
        _rigidbody.velocity = Vector3.zero; // 重置骰子速度
        transform.position = initialPosition; // 将骰子位置重置为初始位置

        // 随机生成一个力向量，使骰子运动方向随机
        Vector3 throwForce = new Vector3(
            x: Random.Range(-2f, 2f),
            y: Random.Range(2f, 2f),
            z: Random.Range(-2f, 2f)
        );

        // 施加一个力使骰子开始运动
        _rigidbody.AddForce(throwForce, ForceMode.Impulse);
        transform.Rotate(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        isThrown = true;
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == emptyCube)
        {
            // 骰子碰撞到透明立方体后，启用重力使骰子受重力影响，下落到透明立方体内部
            _rigidbody.useGravity = true;
        }
        else
        {
            // 骰子与其他物体碰撞时，反弹
            Vector3 normal = collision.contacts[0].normal;
            _rigidbody.velocity = Vector3.Reflect(_rigidbody.velocity, normal);
        }
    }
}
