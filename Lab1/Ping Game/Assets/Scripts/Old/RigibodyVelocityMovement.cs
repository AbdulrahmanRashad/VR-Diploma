using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigibodyVelocityMovement : MonoBehaviour
{

    Rigidbody rb; 
    [SerializeField] float SpeedMul = 200;
    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody>();    
        rb.velocity = transform.forward * Time.deltaTime * SpeedMul;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
