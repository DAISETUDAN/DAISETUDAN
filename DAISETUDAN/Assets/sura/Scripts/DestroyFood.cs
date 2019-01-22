using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour {

    bool trg = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (trg) {
            Destroy(gameObject , 0.5f);
            trg = false;
        }
	}
}
