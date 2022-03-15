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

    public bool isDead;

    void Start()
    {

        string[] maths1 = new string[] { "2x2+2", "3x2-1", "3x3x3-13", "5x5/5", "1/1x7", "10+20/4" };
        string[] maths2 = new string[] { "30+5-4", "2x2+2x2+2x2", "5x5x5/25", "50/2-5", "5", "6x6-6" };
        string[] maths3 = new string[] { "15+2x2", "20+1-1", "-1+20-1", "4+4", "20/2x2", "10x5x2-101" };
        string[] maths4 = new string[] { "32+2-2+2-2+2", "40/4x10", "38+2+2+2-4", "30+30/5", "5-5x12", "6x6+4" };
        string[] maths5 = new string[] { "2x2", "2x2x2-6", "2x2+2", "2x2x2x2/16+2", "2", "2/2+4+1" };
        string[] maths6 = new string[] { "36/6x2", "9x9+9", "8x9+9", "45+5x5", "", "1x1x89x1" };
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
