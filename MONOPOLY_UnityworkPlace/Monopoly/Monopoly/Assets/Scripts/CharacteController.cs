using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacteController : MonoBehaviour
{
    private CharacteController _character;
    private Animator _animator;


    // Start is called before the first frame update
    void Start()
    {
        //声明角色控制器和animator
        _character = GetComponent<CharacteController>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x:horizontal, y:0, z:vertical);

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion .LookRotation(dir);

            _animator.SetBool(name:"isRun", value:true);



            transform.Translate(Vector3.forward * 1 * Time.deltaTime);
        }else
        {
            _animator.SetBool(name:"isRun",value:false);
        }



    }
}
