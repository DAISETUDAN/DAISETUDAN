using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cock : MonoBehaviour {
    public Sprite [] recipe;
    public bool[] buttonTrg;

    bool recipeTrg;
    public int rdm;
	// Use this for initialization
	void Start () {
        recipeTrg = true;
        for (int i = 0; i < 6; i++)
        {
            buttonTrg[i] = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        //料理が出来たらのif文を書く

        if (/*食材三つ切れたら*/Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 6; i++)
            {
                buttonTrg[i] = false;
            }
            FindObjectOfType<Count>().scoreNum++;
            recipeTrg = true;
        }

        if (recipeTrg)
        {
            rdmRecipe();
            recipeTrg = false;
        }
	}

    void rdmRecipe()
    {
        rdm = Random.Range(1, 4);
        switch (rdm)
        {
            case 1:
                Debug.Log("カレー");
                this.gameObject.GetComponent<Image>().sprite = recipe[0];
                break;
            case 2:
                Debug.Log("ステーキ");
                this.gameObject.GetComponent<Image>().sprite = recipe[1];
                break;
            case 3:
                Debug.Log("ムニエル");
                this.gameObject.GetComponent<Image>().sprite = recipe[2];
                break;
        }
    }
}
