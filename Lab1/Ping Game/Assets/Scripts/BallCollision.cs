using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private MeshRenderer Mr;
    public GameObject[] cubes = new GameObject[4];
    private GameObject Ob1;

    // Start is called before the first frame update
    void Start()
    {
        Mr = GetComponent<MeshRenderer>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Right1") || gameObject.CompareTag("Right2"))
        {
            Color customColor = new Color(0.4f, 0.9f, 0.7f, 1.0f);
            Mr.material.SetColor("_Color", customColor);
        }

        if (gameObject.CompareTag("Left1") || gameObject.CompareTag("Left2"))
        {
            Color customColor = new Color(0.6f, 0.2f, 0.9f, 1.0f);
            Mr.material.SetColor("_Color", customColor);
        }
   
    }

    private void OnTriggerEnter(Collider other)
    {

        Ob1 = GameObject.FindWithTag("Right1");
        Ob1.GetComponent<MeshRenderer>().material.color = Color.white;
        Ob1 = GameObject.FindWithTag("Right2");
        Ob1.GetComponent<MeshRenderer>().material.color = Color.white;
        Ob1 = GameObject.FindWithTag("Left1");
        Ob1.GetComponent<MeshRenderer>().material.color = Color.white;
        Ob1 = GameObject.FindWithTag("Left2");
        Ob1.GetComponent<MeshRenderer>().material.color = Color.white;

    }
}
