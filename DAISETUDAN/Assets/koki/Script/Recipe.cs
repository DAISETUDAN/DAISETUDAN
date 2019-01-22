using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipe : MonoBehaviour {

    public Sprite[] recipeFood;
    int recipeNum;
	
    // Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        recipeNum = FindObjectOfType<Cock>().rdm;

        switch (recipeNum)
        {
            case 1:

                this.gameObject.GetComponent<Image>().sprite = recipeFood[0];
                break;
            case 2:

                this.gameObject.GetComponent<Image>().sprite = recipeFood[1];
                break;
            case 3:

                this.gameObject.GetComponent<Image>().sprite = recipeFood[2];
                break;
        }
    }
}
