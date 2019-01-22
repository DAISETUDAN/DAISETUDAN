using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public GameObject meet;
    public GameObject mxMeet;
    public GameObject beg;
    public GameObject fish;
    public GameObject mush;
    public GameObject ruu;

 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void meetClick()
    {
        if (FindObjectOfType<Cock>().buttonTrg[0] == false)
        {
            Debug.Log("肉出現");
            FindObjectOfType<Decision>().num = 5;
            Instantiate(meet, new Vector2(0, 0), Quaternion.identity);
            FindObjectOfType<Cock>().buttonTrg[0] = true;
        }
    }

    public void mxMeetClick()
    {
        if (FindObjectOfType<Cock>().buttonTrg[1] == false)
        {
            Debug.Log("ひき肉出現");
            FindObjectOfType<Decision>().num = 5;
            Instantiate(mxMeet, new Vector2(0, 0), Quaternion.identity);
            FindObjectOfType<Cock>().buttonTrg[1] = true;
        }
    }

    public void begClick()
    {
        if (FindObjectOfType<Cock>().buttonTrg[2] == false)
        {
            Debug.Log("野菜出現");
            FindObjectOfType<Decision>().num = 4;
            Instantiate(beg, new Vector2(0, 0), Quaternion.identity);
            FindObjectOfType<Cock>().buttonTrg[2] = true;
        }
    }

    public void fishClick()
    {
        if (FindObjectOfType<Cock>().buttonTrg[3] == false)
        {
            Debug.Log("魚出現");
            FindObjectOfType<Decision>().num = 3;
            Instantiate(fish, new Vector2(0, 0), Quaternion.identity);
            FindObjectOfType<Cock>().buttonTrg[3] = true;
        }
    }
    public void mushClick()
    {
        if (FindObjectOfType<Cock>().buttonTrg[4] == false)
        {
            Debug.Log("キノコ出現");
            FindObjectOfType<Decision>().num = 4;
            Instantiate(mush, new Vector2(0, 0), Quaternion.identity);
            FindObjectOfType<Cock>().buttonTrg[4] = true;
        }
    }

    public void ruuClick()
    {
        if (FindObjectOfType<Cock>().buttonTrg[5] == false)
        {
            Debug.Log("kare-ru-出現");
            FindObjectOfType<Decision>().num = 3;
            Instantiate(ruu, new Vector2(0, 0), Quaternion.identity);
            FindObjectOfType<Cock>().buttonTrg[5] = true;
        }
    }
}
