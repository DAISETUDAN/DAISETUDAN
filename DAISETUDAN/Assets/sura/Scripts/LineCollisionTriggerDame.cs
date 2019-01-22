using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollisionTriggerDame : MonoBehaviour {

    public bool trg = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision other) {
        //ラインとの当たり判定
        if (other.gameObject.tag == "Line") {
            if (trg) {
                FindObjectOfType<drawPhysicsLine>().pena++;
                Debug.Log("ダメ");
            }
            trg = false;
        }
    }
}
