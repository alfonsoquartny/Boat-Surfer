using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{

    bool toplandiMi;
     int index;
    void Start()
    {
        toplandiMi = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (toplandiMi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
        
    }

    public bool GetToplandiMi()
    {
        return toplandiMi;
    }
    public void ToplandiYap()
    {
        toplandiMi = true;
    }

    public void IndexAyarla(int index)
    {
        this.index = index;
    }
}
