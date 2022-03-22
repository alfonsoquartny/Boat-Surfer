using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour
{
    public GameObject timeLine;

    private void Start()
    {
        timeLine.SetActive(false);
    }
    public void TimeLineAc()
    {
        timeLine.SetActive(true);
    }

    public void exit()
    {
        Application.Quit();
    }
}
