using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class manager : MonoBehaviour
{
    public bool isPause;
    public bool durdu;

    public GameObject durdurObject;
    public GameObject devamObject;
    void Start()
    {
        durdurObject.SetActive(true);
        devamObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPause==true)
        {
            Time.timeScale = 0;
        }
        if (isPause==false)
        {
            Time.timeScale = 1;
        }
    }

    public void Durdur()
    {
        isPause = true;
        durdurObject.SetActive(false);
        devamObject.SetActive(true);
    }
    public void Devam()
    {
        isPause = false;
        durdurObject.SetActive(true);
        devamObject.SetActive(false);
    }
}
