using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cokecounter : MonoBehaviour {

    int Result;
    public GameObject score_object = null; // Textオブジェクト
    // Use this for initialization
    void Start()
    {
        Text score_text = score_object.GetComponent<Text>();

        Result = Count.getCoke();
        score_text.text = "" + Result;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
