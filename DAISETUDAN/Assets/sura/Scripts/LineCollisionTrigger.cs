using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollisionTrigger : MonoBehaviour {

    public bool trg = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0)) {
            trg = true;
            FindObjectOfType<drawPhysicsLine>().ok = 0;
        }
    }

    private void OnCollisionEnter(Collision other) {
        //ラインとの当たり判定
        if (other.gameObject.tag == "Line") {
            if (trg) {
                FindObjectOfType<drawPhysicsLine>().ok++;
                Debug.Log("いいぞ。");
            }
            trg = false;
        }
    }
}
