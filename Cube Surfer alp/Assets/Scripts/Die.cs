using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public bool isLose;
    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public int engineSayi=3;
    void Start()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isLose == true)
        {
            engineSayi = engineSayi - 1;
            isLose = false;
        }

        if (engineSayi == 2)
        {
            particle1.SetActive(true);
        }
        if (engineSayi == 1)
        {
            particle2.SetActive(true);
        }
        if (engineSayi == 0)
        {
            particle3.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isLose = true;
        }
    }
}
