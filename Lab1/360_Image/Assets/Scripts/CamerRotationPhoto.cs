using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CamerRotationPhoto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public Renderer photoTexture;
    public float rotationAngle = 45f;

    /*public void Start()
    {
        // Set the initial texture of the object
        GetComponent<Renderer>().material.mainTexture = photoTexture;
    }*/

    public void Rotate360Photoright()
    {
        // Rotate the texture by the specified angle per frame
        photoTexture.material.SetInt("_Rotation", photoTexture.material.GetInt("_Rotation") + 1);
    }
    public void Rotate360Photoleft()
    {
        photoTexture.material.SetInt("_Rotation", photoTexture.material.GetInt("_Rotation") - 1);
    }

    public void ClickStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
