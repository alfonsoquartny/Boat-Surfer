using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mathRandom : MonoBehaviour
{
    public int sayilar = 0;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;

    public GameObject[] walls;

    public bool isDead;

    void Start()
    {

        string[] maths1 = new string[] { "2x2","2+2","4/2" };//KAYBET
        string[] maths2 = new string[] { "3+3","3x2","6/2" };//KAZAN
        string[] maths3 = new string[] { "15+2x2", "20-1", "-1+20", "5x5-6", "9+9+1", "19" };//KAYBET
        string[] maths4 = new string[] { "4x4+4", "", "16+4", "4x5", "5x4", "19+1" };//KAZAN
        string[] maths5 = new string[] { "10x3", "3x10", "31-1", "6x5", "30+1", "6x6-6" };//KAZAN
        string[] maths6 = new string[] { "2x10+5", "4x4+9", "6x5-5", "25x1x1", "1x25x1", "5x5" };
        string[] maths7 = new string[] { "15+10", "5x5+2", "5x10/2-2", "2x10+4", "3x3x2", "23" };
        string randomName1 = maths1[Random.Range(0, maths1.Length)];
        string randomName2 = maths2[Random.Range(0, maths2.Length)];
        string randomName3 = maths3[Random.Range(0, maths3.Length)];
        string randomName4 = maths4[Random.Range(0, maths4.Length)];
        string randomName5 = maths5[Random.Range(0, maths5.Length)];
        string randomName6 = maths6[Random.Range(0, maths6.Length)];
        string randomName7 = maths6[Random.Range(0, maths7.Length)];
        text1.text = randomName1;
        text2.text = randomName2;
        text3.text = randomName3;
        text4.text = randomName4;
        text5.text = randomName5;
        text6.text = randomName6;
        text7.text = randomName7;
    }   

    public void RandomMathTake()
    {
       
    }

    void Update()
    {

    }

}
