using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTunagu : MonoBehaviour {

    public GameObject point01;
    public GameObject point02;

    public GameObject origin;

    LineRenderer lineY;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        Line();

	}

    void Line() {
        lineY = origin.GetComponent<LineRenderer>();

        lineY.SetPosition(0 , point01.transform.position);
        lineY.SetPosition(1 , point02.transform.position);
    }
}
