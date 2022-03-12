using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
    public Bildirimler bildirimler;
    public anan anan;
    public ButtonScript buttonScirpt;
    [SerializeField]
    public float ileriGitmeHizi;
    [SerializeField]
    public float sagaSolaGitmeHizi;

    public float speed;

    public Rigidbody rb;
    void Start()
    {
        bildirimler.BildirimGonder();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * sagaSolaGitmeHizi * Time.deltaTime;
        this.transform.Translate(yatayEksen, 0, ileriGitmeHizi * Time.deltaTime);

        if (buttonScirpt.isPressLeft == true)
        {
            rb.AddForce(-speed * sagaSolaGitmeHizi * Time.deltaTime, 0, 0);
        }
        if(buttonScirpt.isPressLeft==false)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        if (anan.isPressRight == true)
        {
            rb.AddForce(speed*sagaSolaGitmeHizi*Time.deltaTime, 0, 0);
        }
        if (anan.isPressRight == false)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("finish"))
        {
            SceneManager.LoadScene(0);
        }
    }


}
