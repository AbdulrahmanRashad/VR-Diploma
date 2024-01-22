using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [Range(0, 10)]
    [SerializeField] private int SpeedMul = 2;
    Vector3 defaultBallPos;
    void Start()
    {
        defaultBallPos = transform.position;

    }
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 90, 0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.forward * Time.deltaTime * SpeedMul;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.forward * Time.deltaTime * SpeedMul;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       transform.position = defaultBallPos;
    }
}
