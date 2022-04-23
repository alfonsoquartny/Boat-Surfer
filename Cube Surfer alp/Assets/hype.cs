using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hype : MonoBehaviour
{
    public bool isHype;
    public Camera hypeCamera;
    public Animator lightAnimator;
    public GameObject hypeText;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isHype = true;
        }
        if (isHype==true)
        {
            lightAnimator.SetBool("hype", true);
            hypeCamera.clearFlags = CameraClearFlags.SolidColor;
            hypeText.SetActive(true);
        }
        else
        {
            lightAnimator.SetBool("hype", false);
            hypeCamera.clearFlags = CameraClearFlags.Skybox;
            hypeText.SetActive(false);
        }
    }
}
