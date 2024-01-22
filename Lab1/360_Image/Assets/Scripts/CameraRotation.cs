using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class CameraRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public VideoPlayer videoPlayer;
    public float rotationAngle1 = 45f;

    public void Rotate360Videoright()
    {
        // Set the initial rotation of the video player
        videoPlayer.transform.eulerAngles += new Vector3(0f, rotationAngle1, 0f);
    }


    public void Rotate360Videoleft()
    {
        // Set the initial rotation of the video player
        videoPlayer.transform.eulerAngles -= new Vector3(0f, rotationAngle1, 0f);
    }

    public void ClickStart()
    {
        SceneManager.LoadScene("Img_Scene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
