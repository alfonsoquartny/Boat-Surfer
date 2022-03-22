using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public bool isLeft;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isLeft == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);

        }
        if (isLeft == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("leftTrigger"))
        {
            isLeft = true;
        }
        if (other.gameObject.CompareTag("rightTrigger"))
        {
            isLeft = false;
        }
    }
}
