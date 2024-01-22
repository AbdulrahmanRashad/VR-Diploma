using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalandWorldSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if (gameObject.name == "Plane")
        //{
        //    transform.position = new Vector3(10, 10, 10);

        //}
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gameObject.name + "World Position = " + transform.position);
        //Debug.Log(gameObject.name + "Local Position = " + transform.localPosition);

        
        if (gameObject.name == "Capsule")
        {
            transform.position += new Vector3(0, 0, 1) * Time.deltaTime;

        }
        else if(gameObject.name == "Capsule (1)")
        {
            transform.position += transform.forward * Time.deltaTime;
        }
        else if (gameObject.name == "Capsule (2)")
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }

        //Debug.Log(gameObject.name + "World Position = " + transform.position);
        //Debug.Log(gameObject.name + "Local Position = " + transform.localPosition);

    }

    
 
}
