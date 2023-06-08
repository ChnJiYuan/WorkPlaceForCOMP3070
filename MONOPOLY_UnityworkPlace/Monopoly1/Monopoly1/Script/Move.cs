using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KeyTest : MonoBehaviour
{
    public NavMeshAgent _charactor;
    public Tansform targetTansform;
    // Start is called before the first frame update
    void Start()
    {
        _charactor = this.GetComponent<NavMeshAgent>();
        if (_charactor != null && targetTansform!=null) {
            _charactor.destination = targetTansform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
