using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDestroy : MonoBehaviour {

    public GameObject harf;
    public bool trg = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (trg) {
            Instantiate(harf, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
