using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplar : MonoBehaviour
{

     GameObject motherKup;
     int yukseklik;


    void Start()
    {
        motherKup = GameObject.Find("motherKup");
    }

    // Update is called once per frame
    void Update()
    {
        motherKup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect")
        {
            yukseklik += 1;
            other.gameObject.transform.parent = motherKup.transform;
           
            other.gameObject.GetComponent<Collectables>().ToplandiYap();
            other.gameObject.GetComponent<Collectables>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = motherKup.transform;

        }
    }
}
