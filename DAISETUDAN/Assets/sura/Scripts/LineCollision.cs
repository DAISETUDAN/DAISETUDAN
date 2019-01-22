using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollision : MonoBehaviour {

    public bool trg = true;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonUp(0)) {
            Destroy(gameObject);
        }
    }
}