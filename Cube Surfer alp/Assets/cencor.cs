using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cencor : MonoBehaviour
{
    public Die die;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            die.isLose = true;
        }
    }
}
